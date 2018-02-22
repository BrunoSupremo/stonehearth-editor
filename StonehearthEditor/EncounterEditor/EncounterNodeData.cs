﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Msagl.Drawing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Image = System.Drawing.Image;
using System.Windows.Forms;

namespace StonehearthEditor
{
    public class EncounterNodeData : NodeData
    {
        private string mEncounterType;
        private string mInEdge; // This is the name of the node as referred to others by the out edges of others.
        private List<string> mOutEdgeStrings;
        private Dictionary<string, List<string>> mChoiceEdgeInfo; // Map of edge to list of choices
        private bool mIsStartNode = false;

        public bool IsStartNode
        {
            get { return mIsStartNode; }
        }

        public string InEdge
        {
            get { return mInEdge; }
        }

        public List<string> OutEdgeStrings
        {
            get { return new List<string>(mOutEdgeStrings); }
        }

        public string EncounterType
        {
            get { return mEncounterType; }
        }

        public override void PostLoadFixup()
        {
            string selector = null;
            string monsterTuningSelector = null;
            switch (mEncounterType)
            {
                case "create_camp":
                    selector = "create_camp_info.*.loot_drops";
                    break;
                case "city_raid":
                    selector = "city_raid_info.missions.*.members.*.loot_drops";
                    monsterTuningSelector = "city_raid_info.missions.*.members.*";
                    break;
                case "donation_dialog":
                    selector = "donation_dialog_info.loot_table";
                    break;
                case "donation":
                    selector = "donation_info.loot_table";
                    break;
                case "create_mission":
                    selector = "create_mission_info.mission.members.*.loot_drops";
                    monsterTuningSelector = "create_mission_info.mission.members.*";
                    break;
            }

            if (selector != null)
            {
                FixupLoot(selector);
            }

            if (monsterTuningSelector != null)
            {
                if (NodeFile.Json != null)
                {
                    foreach (JToken token in NodeFile.Json.SelectTokens(monsterTuningSelector))
                    {
                        if (token["tuning"] == null)
                        {
                            Console.WriteLine(NodeFile.Path + " does not have monster tuning!");
                        }
                    }
                }
            }
        }

        public override void LoadData(Dictionary<string, GameMasterNode> allNodes)
        {
            mOutEdgeStrings = new List<string>();
            mChoiceEdgeInfo = new Dictionary<string, List<string>>();
            mEncounterType = NodeFile.Json["encounter_type"].ToString();
            mInEdge = NodeFile.Json["in_edge"].ToString();

            if (mInEdge.Equals("start"))
            {
                mIsStartNode = true;
            }

            mOutEdgeStrings = ParseOutEdges(NodeFile.Json["out_edge"]);
            switch (mEncounterType)
            {
                case "generator":
                    JToken generatorInfo = NodeFile.Json["generator_info"];
                    if (generatorInfo.SelectToken("spawn_edge") != null)
                    {
                        AddOutEdgesRecursive(generatorInfo["spawn_edge"], mOutEdgeStrings);
                    }

                    break;
                case "collection_quest":
                    Dictionary<string, string> collectionEdges = JsonHelper.GetJsonStringDictionary(NodeFile.Json["collection_quest_info"], "out_edges");
                    foreach (KeyValuePair<string, string> collectionEdge in collectionEdges)
                    {
                        string outEdge = collectionEdge.Value;
                        string choice = collectionEdge.Key;
                        if (!outEdge.Equals("none"))
                        {
                            List<string> list;
                            if (!mChoiceEdgeInfo.TryGetValue(outEdge, out list))
                            {
                                list = new List<string>();
                            }

                            list.Add(choice);
                            mChoiceEdgeInfo[outEdge] = list;
                            if (!mOutEdgeStrings.Contains(outEdge))
                            {
                                mOutEdgeStrings.Add(outEdge);
                            }
                        }
                    }

                    break;
                case "town_founding":
                    {
                        var choices = NodeFile.Json.SelectToken("town_founding_info.choices");
                        if (choices != null)
                        {
                            foreach (JToken nodeData in choices.Values())
                            {
                                if (nodeData["out_edge"] != null)
                                {
                                    AddOutEdgesRecursive(nodeData["out_edge"], mOutEdgeStrings);
                                }
                            }
                        }
                        break;
                    }
                case "delivery_quest":
                    if (NodeFile.Json.SelectToken("delivery_quest_info.abandon_out_edge") != null)
                    {
                        AddOutEdgesRecursive(NodeFile.Json.SelectToken("delivery_quest_info.abandon_out_edge"), mOutEdgeStrings);
                    }
                    break;
                case "dispatch_quest":
                    if (NodeFile.Json.SelectToken("dispatch_quest_info.abandon_out_edge") != null)
                    {
                        AddOutEdgesRecursive(NodeFile.Json.SelectToken("dispatch_quest_info.abandon_out_edge"), mOutEdgeStrings);
                    }
                    break;
                case "dialog_tree":
                    // Go through all the dialog nodes and add ot edges
                    foreach (JToken dialogNode in NodeFile.Json["dialog_tree_info"]["nodes"].Children())
                    {
                        JToken choices = dialogNode.First["bulletin"]["choices"];
                        foreach (JToken nodeData in choices.Values())
                        {
                            string parentName = (nodeData.Parent as JProperty).Name;
                            string translatedParentName = ModuleDataManager.GetInstance().LocalizeString(parentName);
                            JToken outEdgeSpec = nodeData["out_edge"];
                            if (outEdgeSpec != null)
                            {
                                List<string> outEdges = new List<string>();
                                AddOutEdgesRecursive(nodeData["out_edge"], outEdges);
                                foreach(string outEdge in outEdges)
                                {
                                    List<string> list;
                                    if (!mChoiceEdgeInfo.TryGetValue(outEdge, out list))
                                    {
                                        list = new List<string>();
                                    }

                                    list.Add(translatedParentName);
                                    mChoiceEdgeInfo[outEdge] = list;
                                    if (!mOutEdgeStrings.Contains(outEdge))
                                    {
                                        mOutEdgeStrings.Add(outEdge);
                                    }
                                }
                            }
                        }
                    }

                    break;
                case "counter":
                    foreach (JToken nodeData in NodeFile.Json["counter_info"]["out_edges"].Values())
                    {
                        mOutEdgeStrings.Add(nodeData.ToString());
                    }

                    break;
            }
        }

        public override void UpdateGraphNode(Node graphNode)
        {
            base.UpdateGraphNode(graphNode);

            var settings = graphNode.UserData as EncounterNodeRenderer.NodeDisplaySettings;

            var iconBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            switch (mEncounterType)
            {
                case "generator":
                    graphNode.Attr.FillColor = GameMasterNode.kOrange;
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_generator.png");
                    break;
                case "none":
                    graphNode.Attr.FillColor = GameMasterNode.kGrey;
                    break;
                case "create_camp":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_camp.png");
                    break;
                case "wait":
                case "wait_for_event":
                case "wait_for_net_worth":
                case "wait_for_requirements_met":
                case "wait_for_time_of_day":
                case "item_threshold":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_wait.png");
                    break;
                case "dialog_tree":
                case "donation_dialog":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_dialog.png");
                    break;
                case "script":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_script.png");
                    break;
                case "shop":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_shop.png");
                    break;
                case "counter":
                case "set_counters":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_counter.png");
                    break;
                case "destroy_entity":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_destroy.png");
                    break;
                case "unlock_recipe":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_recipe.png");
                    break;
                case "collection_quest":
                case "delivery_quest":
                case "dispatch_quest":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_quest.png");
                    break;
                case "city_raid":
                case "create_mission":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_raid.png");
                    break;
                case "city_tier_quest":
                case "town_founding":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_tier_quest.png");
                    break;
                case "city_tier_achieved":
                case "town_upgrade":
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_tier_achieved.png");
                    break;
                case "donation":
                case "add_citizen":  // Pushing it.
                    settings.Icon = Image.FromFile(iconBasePath + "/images/encounter_loot.png");
                    break;
            }

            settings.HasUnsavedChanges = NodeFile.IsModified;

            if (NodeFile.Owner == null)
            {
                settings.HasErrors = true;
            }

            if (!settings.HasErrors)
            {
                var schema = GameMasterDataManager.GetInstance().GetEncounterSchema(mEncounterType);
                var jsonFileData = NodeFile.FileData as JsonFileData;
                if (jsonFileData.Json["mixins"] != null)
                {
                    jsonFileData = jsonFileData.CreateFileWithMixinsApplied();
                }

                settings.HasErrors = schema.Validate(jsonFileData.Json).Count > 0;
            }
        }

        public override NodeData Clone(GameMasterNode nodeFile)
        {
            EncounterNodeData newNodeData = new EncounterNodeData();
            newNodeData.NodeFile = nodeFile;
            newNodeData.mEncounterType = mEncounterType;
            newNodeData.mInEdge = mInEdge;
            newNodeData.mOutEdgeStrings = new List<string>();
            newNodeData.mIsStartNode = mIsStartNode;

            if (NodeFile.Owner != null && NodeFile.Owner.NodeType == GameMasterNodeType.ARC)
            {
                ArcNodeData ownerArcData = NodeFile.Owner.NodeData as ArcNodeData;
                ownerArcData.AddEncounter(newNodeData);
                nodeFile.Owner = NodeFile.Owner;
            }

            return newNodeData;
        }

        public override bool AddOutEdge(GameMasterNode nodeFile)
        {
            if (nodeFile.NodeType != GameMasterNodeType.ENCOUNTER)
            {
                return false;
            }

            EncounterNodeData encounterData = nodeFile.NodeData as EncounterNodeData;
            string inEdge = encounterData.InEdge;

            if (encounterData.IsStartNode)
            {
                // Cannot add start nodes to an encounter. they should be added to arc
                return false;
            }

            List<string> outEdges = GetOutEdges();
            if (outEdges.Contains(nodeFile.Id))
            {
                // This item is already part of the out edges
                return false;
            }

            if (!mOutEdgeStrings.Contains(inEdge))
            {
                // This out edge isn't already in the list of possible out edges, see if we can add it.
                switch (mEncounterType)
                {
                    case "generator":
                        // Cannot add more than one edge to generator
                        return false;
                    case "random_out_edge":
                        JObject randomOutEdgesDictionary = (JObject)NodeFile.Json["random_out_edge_info"]["out_edges"];
                        randomOutEdgesDictionary.Add(inEdge, JObject.Parse(@"{""weight"":1 }"));
                        mOutEdgeStrings.Add(inEdge);
                        break;
                    case "collection_quest":
                        return false;
                    case "dialog_tree":
                        // We can't add to a dialog tree, you have to specify a node.
                        return false;
                    case "counter":
                        // Cannot add to a counter because it either does fail or success
                        return false;
                    default:
                        NodeFile.Json.Remove("out_edge");
                        mOutEdgeStrings.Add(inEdge);
                        NodeFile.Json.Add("out_edge", JsonConvert.SerializeObject(mOutEdgeStrings));
                        break;
                }
            }

            if (nodeFile.Owner != NodeFile.Owner)
            {
                // make sure encounter is added to this tree
                ArcNodeData ownerArcData = NodeFile.Owner.NodeData as ArcNodeData;
                ownerArcData.AddEncounter(encounterData);
                nodeFile.Owner = NodeFile.Owner;
            }

            NodeFile.IsModified = true;
            return true;
        }

        protected override void UpdateOutEdges(Graph graph)
        {
            GameMasterNode arcFile = NodeFile.Owner;
            ArcNodeData arc = arcFile?.NodeData as ArcNodeData;
            if (arc != null)
            {
                foreach (string inEdgeName in mOutEdgeStrings)
                {
                    List<GameMasterNode> linkedEncounters = arc.GetEncountersWithInEdge(inEdgeName);
                    if (linkedEncounters.Count == 1 && linkedEncounters[0].Name.Equals(inEdgeName))
                    {
                        if (mChoiceEdgeInfo.ContainsKey(inEdgeName))
                        {
                            foreach (string choice in mChoiceEdgeInfo[inEdgeName])
                            {
                                Node choiceNode = graph.AddNode(NodeFile.Id + "#" + choice);
                                choiceNode.LabelText = '"' + choice + '"';
                                MakeNodePrivate(choiceNode);
                                graph.AddEdge(NodeFile.Id, choiceNode.Id).UserData = inEdgeName;
                                graph.AddEdge(choiceNode.Id, linkedEncounters[0].Id).UserData = inEdgeName;
                            }
                        }
                        else
                        {
                            graph.AddEdge(NodeFile.Id, linkedEncounters[0].Id).UserData = inEdgeName;
                        }
                    }
                    else
                    {
                        Node arcOutNode = graph.AddNode(arcFile.Id + "#" + inEdgeName);
                        arcOutNode.LabelText = inEdgeName;
                        MakeNodePrivate(arcOutNode);
                        if (mChoiceEdgeInfo.ContainsKey(inEdgeName))
                        {
                            foreach (string choice in mChoiceEdgeInfo[inEdgeName])
                            {
                                Node choiceNode = graph.AddNode(NodeFile.Id + "#" + choice);
                                choiceNode.LabelText = '"' + choice + '"';
                                MakeNodePrivate(choiceNode);
                                graph.AddEdge(NodeFile.Id, choiceNode.Id).UserData = inEdgeName;
                                graph.AddEdge(choiceNode.Id, arcOutNode.Id).UserData = inEdgeName;
                            }
                        }
                        else
                        {
                            graph.AddEdge(NodeFile.Id, arcOutNode.Id).UserData = inEdgeName;
                        }

                        foreach (GameMasterNode linkedEncounter in linkedEncounters)
                        {
                            graph.AddEdge(arcOutNode.Id, linkedEncounter.Id).UserData = inEdgeName;
                        }
                    }
                }
            }
        }

        // Returns list of out edges
        private List<string> GetOutEdges()
        {
            List<string> outEdges = new List<string>();
            GameMasterNode arcFile = NodeFile.Owner;
            if (arcFile != null)
            {
                ArcNodeData arc = arcFile.NodeData as ArcNodeData;
                foreach (string inEdgeName in mOutEdgeStrings)
                {
                    foreach (GameMasterNode linkedEncounter in arc.GetEncountersWithInEdge(inEdgeName))
                    {
                        outEdges.Add(linkedEncounter.Id);
                    }
                }
            }

            return outEdges;
        }

        private void AddOutEdgesRecursive(JToken outEdgeSpec, List<string> list)
        {
            if (!(outEdgeSpec is JValue))
            {
                string specType = outEdgeSpec["type"].ToString();
                switch (specType)
                {
                    case "trigger_one":
                    case "trigger_many":
                        JToken outEdges = outEdgeSpec["out_edges"];
                        IList<JToken> results = outEdges.ToList();
                        foreach (JToken child in results)
                        {
                            AddOutEdgesRecursive(child, list);
                        }
                        if (specType == "trigger_one")
                        {
                            JToken fallbackEdge = outEdgeSpec["fallback"];
                            if (fallbackEdge != null)
                            {
                                AddOutEdgesRecursive(fallbackEdge, list);
                            }
                        }

                        break;
                    case "weighted_edge":
                        JToken outEdge = outEdgeSpec["out_edge"];
                        AddOutEdgesRecursive(outEdge, list);
                        break;
                }
            }
            else
            {
                list.Add(outEdgeSpec.ToString());
            }
        }

        private List<string> ParseOutEdges(JToken outEdgeSpec)
        {
            List<string> returned = new List<string>();
            if (outEdgeSpec != null)
            {
                AddOutEdgesRecursive(outEdgeSpec, returned);
            }

            return returned;
        }
    }
}
