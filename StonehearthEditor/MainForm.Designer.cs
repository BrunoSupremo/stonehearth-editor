﻿namespace StonehearthEditor
{
   partial class StonehearthEditor
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StonehearthEditor));
         this.treeView = new System.Windows.Forms.TreeView();
         this.manifestImageList = new System.Windows.Forms.ImageList(this.components);
         this.aliasContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.aliasContextDuplicate = new System.Windows.Forms.ToolStripMenuItem();
         this.selectedFilePathLabel = new System.Windows.Forms.Label();
         this.tabControl = new System.Windows.Forms.TabControl();
         this.manifestTab = new System.Windows.Forms.TabPage();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.searchPanel = new System.Windows.Forms.Panel();
         this.searchBox = new System.Windows.Forms.TextBox();
         this.searchButton = new System.Windows.Forms.Button();
         this.splitContainer3 = new System.Windows.Forms.SplitContainer();
         this.filePreviewTabs = new System.Windows.Forms.TabControl();
         this.openFileButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.dependenciesListView = new System.Windows.Forms.ListView();
         this.dependenciesLabel = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.iconView = new System.Windows.Forms.PictureBox();
         this.encounterTab = new System.Windows.Forms.TabPage();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.encounterTabRightSide = new System.Windows.Forms.Panel();
         this.graphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
         this.encounterGraphContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.copyGameMasterNode = new System.Windows.Forms.ToolStripMenuItem();
         this.addNewGameMasterNode = new System.Windows.Forms.ToolStripMenuItem();
         this.deleteNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.encounterRightSideFilePath = new System.Windows.Forms.TextBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.nodeInfoJsonPreview = new System.Windows.Forms.RichTextBox();
         this.nodeInfoPanel = new System.Windows.Forms.Panel();
         this.openEncounterFileButton = new System.Windows.Forms.Button();
         this.nodeInfoSubType = new System.Windows.Forms.Label();
         this.nodeInfoType = new System.Windows.Forms.Label();
         this.nodeInfoName = new System.Windows.Forms.Label();
         this.encounterTreeView = new System.Windows.Forms.TreeView();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolstripSaveButton = new System.Windows.Forms.ToolStripButton();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.i18nTooltip = new System.Windows.Forms.ToolTip(this.components);
         this.saveNewEncounterNodeDialog = new System.Windows.Forms.SaveFileDialog();
         this.modsFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
         this.mainFormMenu = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.changeModDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aliasContextMenu.SuspendLayout();
         this.tabControl.SuspendLayout();
         this.manifestTab.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel1.SuspendLayout();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         this.searchPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
         this.splitContainer3.Panel1.SuspendLayout();
         this.splitContainer3.Panel2.SuspendLayout();
         this.splitContainer3.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.iconView)).BeginInit();
         this.encounterTab.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.encounterTabRightSide.SuspendLayout();
         this.encounterGraphContextMenu.SuspendLayout();
         this.panel1.SuspendLayout();
         this.nodeInfoPanel.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.mainFormMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // treeView
         // 
         this.treeView.ContextMenuStrip = this.aliasContextMenu;
         this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeView.HideSelection = false;
         this.treeView.ImageIndex = 0;
         this.treeView.ImageList = this.manifestImageList;
         this.treeView.Location = new System.Drawing.Point(0, 26);
         this.treeView.Name = "treeView";
         this.treeView.SelectedImageIndex = 0;
         this.treeView.Size = new System.Drawing.Size(369, 523);
         this.treeView.TabIndex = 1;
         this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
         this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manifestTreeView_OnMouseClick);
         // 
         // manifestImageList
         // 
         this.manifestImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("manifestImageList.ImageStream")));
         this.manifestImageList.TransparentColor = System.Drawing.Color.Transparent;
         this.manifestImageList.Images.SetKeyName(0, "none.png");
         this.manifestImageList.Images.SetKeyName(1, "entity.png");
         this.manifestImageList.Images.SetKeyName(2, "buff.png");
         this.manifestImageList.Images.SetKeyName(3, "ai_pack.png");
         this.manifestImageList.Images.SetKeyName(4, "effect.png");
         this.manifestImageList.Images.SetKeyName(5, "recipe.png");
         this.manifestImageList.Images.SetKeyName(6, "command.png");
         this.manifestImageList.Images.SetKeyName(7, "animation.png");
         this.manifestImageList.Images.SetKeyName(8, "encounter.png");
         this.manifestImageList.Images.SetKeyName(9, "job.png");
         // 
         // aliasContextMenu
         // 
         this.aliasContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliasContextDuplicate});
         this.aliasContextMenu.Name = "aliasContextMenu";
         this.aliasContextMenu.Size = new System.Drawing.Size(153, 48);
         this.aliasContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.aliasContextMenu_Opening);
         // 
         // aliasContextDuplicate
         // 
         this.aliasContextDuplicate.Name = "aliasContextDuplicate";
         this.aliasContextDuplicate.Size = new System.Drawing.Size(105, 22);
         this.aliasContextDuplicate.Text = "Clone";
         this.aliasContextDuplicate.Click += new System.EventHandler(this.aliasContextMenuDuplicate_Click);
         // 
         // selectedFilePathLabel
         // 
         this.selectedFilePathLabel.AutoSize = true;
         this.selectedFilePathLabel.Dock = System.Windows.Forms.DockStyle.Top;
         this.selectedFilePathLabel.Location = new System.Drawing.Point(0, 0);
         this.selectedFilePathLabel.Name = "selectedFilePathLabel";
         this.selectedFilePathLabel.Size = new System.Drawing.Size(0, 13);
         this.selectedFilePathLabel.TabIndex = 0;
         // 
         // tabControl
         // 
         this.tabControl.Controls.Add(this.manifestTab);
         this.tabControl.Controls.Add(this.encounterTab);
         this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl.Location = new System.Drawing.Point(0, 24);
         this.tabControl.Name = "tabControl";
         this.tabControl.SelectedIndex = 0;
         this.tabControl.Size = new System.Drawing.Size(1123, 581);
         this.tabControl.TabIndex = 3;
         this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
         // 
         // manifestTab
         // 
         this.manifestTab.Controls.Add(this.splitContainer2);
         this.manifestTab.Location = new System.Drawing.Point(4, 22);
         this.manifestTab.Name = "manifestTab";
         this.manifestTab.Padding = new System.Windows.Forms.Padding(3);
         this.manifestTab.Size = new System.Drawing.Size(1115, 555);
         this.manifestTab.TabIndex = 0;
         this.manifestTab.Text = "Manifest";
         this.manifestTab.UseVisualStyleBackColor = true;
         // 
         // splitContainer2
         // 
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(3, 3);
         this.splitContainer2.Name = "splitContainer2";
         // 
         // splitContainer2.Panel1
         // 
         this.splitContainer2.Panel1.Controls.Add(this.treeView);
         this.splitContainer2.Panel1.Controls.Add(this.searchPanel);
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
         this.splitContainer2.Panel2.Controls.Add(this.selectedFilePathLabel);
         this.splitContainer2.Size = new System.Drawing.Size(1109, 549);
         this.splitContainer2.SplitterDistance = 369;
         this.splitContainer2.TabIndex = 2;
         // 
         // searchPanel
         // 
         this.searchPanel.Controls.Add(this.searchBox);
         this.searchPanel.Controls.Add(this.searchButton);
         this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
         this.searchPanel.Location = new System.Drawing.Point(0, 0);
         this.searchPanel.Name = "searchPanel";
         this.searchPanel.Size = new System.Drawing.Size(369, 26);
         this.searchPanel.TabIndex = 5;
         // 
         // searchBox
         // 
         this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.searchBox.Location = new System.Drawing.Point(0, 0);
         this.searchBox.Name = "searchBox";
         this.searchBox.Size = new System.Drawing.Size(346, 20);
         this.searchBox.TabIndex = 3;
         this.searchBox.WordWrap = false;
         this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
         // 
         // searchButton
         // 
         this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
         this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
         this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
         this.searchButton.Location = new System.Drawing.Point(346, 0);
         this.searchButton.Margin = new System.Windows.Forms.Padding(0);
         this.searchButton.Name = "searchButton";
         this.searchButton.Size = new System.Drawing.Size(23, 26);
         this.searchButton.TabIndex = 4;
         this.searchButton.UseVisualStyleBackColor = true;
         // 
         // splitContainer3
         // 
         this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer3.Location = new System.Drawing.Point(0, 13);
         this.splitContainer3.Name = "splitContainer3";
         // 
         // splitContainer3.Panel1
         // 
         this.splitContainer3.Panel1.Controls.Add(this.filePreviewTabs);
         this.splitContainer3.Panel1.Controls.Add(this.openFileButtonPanel);
         // 
         // splitContainer3.Panel2
         // 
         this.splitContainer3.Panel2.Controls.Add(this.panel3);
         this.splitContainer3.Panel2.Controls.Add(this.panel2);
         this.splitContainer3.Size = new System.Drawing.Size(736, 536);
         this.splitContainer3.SplitterDistance = 500;
         this.splitContainer3.TabIndex = 3;
         // 
         // filePreviewTabs
         // 
         this.filePreviewTabs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.filePreviewTabs.Location = new System.Drawing.Point(0, 33);
         this.filePreviewTabs.Name = "filePreviewTabs";
         this.filePreviewTabs.SelectedIndex = 0;
         this.filePreviewTabs.Size = new System.Drawing.Size(500, 503);
         this.filePreviewTabs.TabIndex = 2;
         // 
         // openFileButtonPanel
         // 
         this.openFileButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
         this.openFileButtonPanel.Location = new System.Drawing.Point(0, 0);
         this.openFileButtonPanel.Name = "openFileButtonPanel";
         this.openFileButtonPanel.Size = new System.Drawing.Size(500, 33);
         this.openFileButtonPanel.TabIndex = 0;
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.Color.Transparent;
         this.panel3.Controls.Add(this.dependenciesListView);
         this.panel3.Controls.Add(this.dependenciesLabel);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel3.Location = new System.Drawing.Point(0, 232);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(232, 304);
         this.panel3.TabIndex = 5;
         // 
         // dependenciesListView
         // 
         this.dependenciesListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dependenciesListView.Location = new System.Drawing.Point(0, 13);
         this.dependenciesListView.MultiSelect = false;
         this.dependenciesListView.Name = "dependenciesListView";
         this.dependenciesListView.Size = new System.Drawing.Size(232, 291);
         this.dependenciesListView.TabIndex = 2;
         this.dependenciesListView.UseCompatibleStateImageBehavior = false;
         this.dependenciesListView.View = System.Windows.Forms.View.List;
         this.dependenciesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dependenciesListView_MouseDoubleClick);
         // 
         // dependenciesLabel
         // 
         this.dependenciesLabel.AutoSize = true;
         this.dependenciesLabel.Dock = System.Windows.Forms.DockStyle.Top;
         this.dependenciesLabel.Location = new System.Drawing.Point(0, 0);
         this.dependenciesLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
         this.dependenciesLabel.Name = "dependenciesLabel";
         this.dependenciesLabel.Size = new System.Drawing.Size(79, 13);
         this.dependenciesLabel.TabIndex = 3;
         this.dependenciesLabel.Text = "Dependencies:";
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.iconView);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(232, 232);
         this.panel2.TabIndex = 4;
         // 
         // iconView
         // 
         this.iconView.Location = new System.Drawing.Point(3, 0);
         this.iconView.Name = "iconView";
         this.iconView.Size = new System.Drawing.Size(232, 232);
         this.iconView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.iconView.TabIndex = 3;
         this.iconView.TabStop = false;
         // 
         // encounterTab
         // 
         this.encounterTab.Controls.Add(this.splitContainer1);
         this.encounterTab.Controls.Add(this.encounterTreeView);
         this.encounterTab.Controls.Add(this.toolStrip1);
         this.encounterTab.Location = new System.Drawing.Point(4, 22);
         this.encounterTab.Name = "encounterTab";
         this.encounterTab.Padding = new System.Windows.Forms.Padding(3);
         this.encounterTab.Size = new System.Drawing.Size(1115, 555);
         this.encounterTab.TabIndex = 1;
         this.encounterTab.Text = "Encounter Designer";
         this.encounterTab.UseVisualStyleBackColor = true;
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(253, 28);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.encounterTabRightSide);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.panel1);
         this.splitContainer1.Panel2.Controls.Add(this.nodeInfoPanel);
         this.splitContainer1.Size = new System.Drawing.Size(859, 524);
         this.splitContainer1.SplitterDistance = 356;
         this.splitContainer1.TabIndex = 3;
         // 
         // encounterTabRightSide
         // 
         this.encounterTabRightSide.Controls.Add(this.graphViewer);
         this.encounterTabRightSide.Controls.Add(this.encounterRightSideFilePath);
         this.encounterTabRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
         this.encounterTabRightSide.Location = new System.Drawing.Point(0, 0);
         this.encounterTabRightSide.Name = "encounterTabRightSide";
         this.encounterTabRightSide.Size = new System.Drawing.Size(859, 356);
         this.encounterTabRightSide.TabIndex = 1;
         // 
         // graphViewer
         // 
         this.graphViewer.ArrowheadLength = 10D;
         this.graphViewer.AsyncLayout = false;
         this.graphViewer.AutoScroll = true;
         this.graphViewer.BackwardEnabled = false;
         this.graphViewer.BuildHitTree = true;
         this.graphViewer.ContextMenuStrip = this.encounterGraphContextMenu;
         this.graphViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
         this.graphViewer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.graphViewer.EdgeInsertButtonVisible = true;
         this.graphViewer.FileName = "";
         this.graphViewer.ForwardEnabled = false;
         this.graphViewer.Graph = null;
         this.graphViewer.InsertingEdge = false;
         this.graphViewer.LayoutAlgorithmSettingsButtonVisible = true;
         this.graphViewer.LayoutEditingEnabled = true;
         this.graphViewer.Location = new System.Drawing.Point(0, 20);
         this.graphViewer.LooseOffsetForRouting = 0.25D;
         this.graphViewer.MouseHitDistance = 0.05D;
         this.graphViewer.Name = "graphViewer";
         this.graphViewer.NavigationVisible = true;
         this.graphViewer.NeedToCalculateLayout = true;
         this.graphViewer.OffsetForRelaxingInRouting = 0.6D;
         this.graphViewer.PaddingForEdgeRouting = 8D;
         this.graphViewer.PanButtonPressed = false;
         this.graphViewer.SaveAsImageEnabled = true;
         this.graphViewer.SaveAsMsaglEnabled = true;
         this.graphViewer.SaveButtonVisible = true;
         this.graphViewer.SaveGraphButtonVisible = true;
         this.graphViewer.SaveInVectorFormatEnabled = true;
         this.graphViewer.Size = new System.Drawing.Size(859, 336);
         this.graphViewer.TabIndex = 0;
         this.graphViewer.TightOffsetForRouting = 0.125D;
         this.graphViewer.ToolBarIsVisible = true;
         this.graphViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("graphViewer.Transform")));
         this.graphViewer.UndoRedoButtonsVisible = true;
         this.graphViewer.WindowZoomButtonPressed = false;
         this.graphViewer.ZoomF = 1D;
         this.graphViewer.ZoomFraction = 0.5D;
         this.graphViewer.ZoomWhenMouseWheelScroll = true;
         this.graphViewer.ZoomWindowThreshold = 0.05D;
         this.graphViewer.EdgeAdded += new System.EventHandler(this.graphViewer_EdgeAdded);
         this.graphViewer.EdgeRemoved += new System.EventHandler(this.graphViewer_EdgeRemoved);
         this.graphViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphViewer_MouseMove);
         this.graphViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphViewer_MouseClick);
         this.graphViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphViewer_MouseDown);
         this.graphViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphViewer_MouseUp);
         // 
         // encounterGraphContextMenu
         // 
         this.encounterGraphContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyGameMasterNode,
            this.addNewGameMasterNode,
            this.deleteNodeToolStripMenuItem});
         this.encounterGraphContextMenu.Name = "encounterGraphContextMenu";
         this.encounterGraphContextMenu.Size = new System.Drawing.Size(156, 70);
         // 
         // copyGameMasterNode
         // 
         this.copyGameMasterNode.Enabled = false;
         this.copyGameMasterNode.Name = "copyGameMasterNode";
         this.copyGameMasterNode.Size = new System.Drawing.Size(155, 22);
         this.copyGameMasterNode.Text = "Clone Node";
         this.copyGameMasterNode.Click += new System.EventHandler(this.copyGameMasterNode_Click);
         // 
         // addNewGameMasterNode
         // 
         this.addNewGameMasterNode.Enabled = false;
         this.addNewGameMasterNode.Name = "addNewGameMasterNode";
         this.addNewGameMasterNode.Size = new System.Drawing.Size(155, 22);
         this.addNewGameMasterNode.Text = "Add New Node";
         this.addNewGameMasterNode.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.addNewGameMasterNode_DropDownItemClicked);
         // 
         // deleteNodeToolStripMenuItem
         // 
         this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
         this.deleteNodeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
         this.deleteNodeToolStripMenuItem.Text = "Delete";
         this.deleteNodeToolStripMenuItem.Click += new System.EventHandler(this.deleteNodeToolStripMenuItem_Click);
         // 
         // encounterRightSideFilePath
         // 
         this.encounterRightSideFilePath.Dock = System.Windows.Forms.DockStyle.Top;
         this.encounterRightSideFilePath.Location = new System.Drawing.Point(0, 0);
         this.encounterRightSideFilePath.MaximumSize = new System.Drawing.Size(0, 20);
         this.encounterRightSideFilePath.MinimumSize = new System.Drawing.Size(0, 20);
         this.encounterRightSideFilePath.Name = "encounterRightSideFilePath";
         this.encounterRightSideFilePath.ReadOnly = true;
         this.encounterRightSideFilePath.Size = new System.Drawing.Size(859, 20);
         this.encounterRightSideFilePath.TabIndex = 2;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.nodeInfoJsonPreview);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 30);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(859, 134);
         this.panel1.TabIndex = 5;
         // 
         // nodeInfoJsonPreview
         // 
         this.nodeInfoJsonPreview.Dock = System.Windows.Forms.DockStyle.Fill;
         this.nodeInfoJsonPreview.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.nodeInfoJsonPreview.Location = new System.Drawing.Point(0, 0);
         this.nodeInfoJsonPreview.Margin = new System.Windows.Forms.Padding(10);
         this.nodeInfoJsonPreview.Name = "nodeInfoJsonPreview";
         this.nodeInfoJsonPreview.Size = new System.Drawing.Size(859, 134);
         this.nodeInfoJsonPreview.TabIndex = 4;
         this.nodeInfoJsonPreview.Text = "";
         this.nodeInfoJsonPreview.WordWrap = false;
         this.nodeInfoJsonPreview.Leave += new System.EventHandler(this.nodeInfoJsonPreview_Leave);
         this.nodeInfoJsonPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nodeInfoJsonPreview_MouseMove);
         // 
         // nodeInfoPanel
         // 
         this.nodeInfoPanel.BackColor = System.Drawing.Color.Silver;
         this.nodeInfoPanel.Controls.Add(this.openEncounterFileButton);
         this.nodeInfoPanel.Controls.Add(this.nodeInfoSubType);
         this.nodeInfoPanel.Controls.Add(this.nodeInfoType);
         this.nodeInfoPanel.Controls.Add(this.nodeInfoName);
         this.nodeInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
         this.nodeInfoPanel.Location = new System.Drawing.Point(0, 0);
         this.nodeInfoPanel.Name = "nodeInfoPanel";
         this.nodeInfoPanel.Size = new System.Drawing.Size(859, 30);
         this.nodeInfoPanel.TabIndex = 1;
         // 
         // openEncounterFileButton
         // 
         this.openEncounterFileButton.Location = new System.Drawing.Point(606, 2);
         this.openEncounterFileButton.Name = "openEncounterFileButton";
         this.openEncounterFileButton.Size = new System.Drawing.Size(75, 23);
         this.openEncounterFileButton.TabIndex = 4;
         this.openEncounterFileButton.Text = "Open File";
         this.openEncounterFileButton.UseVisualStyleBackColor = true;
         this.openEncounterFileButton.Click += new System.EventHandler(this.openEncounterFileButton_Click);
         // 
         // nodeInfoSubType
         // 
         this.nodeInfoSubType.AutoSize = true;
         this.nodeInfoSubType.Location = new System.Drawing.Point(330, 13);
         this.nodeInfoSubType.Name = "nodeInfoSubType";
         this.nodeInfoSubType.Size = new System.Drawing.Size(92, 13);
         this.nodeInfoSubType.TabIndex = 3;
         this.nodeInfoSubType.Text = "nodeInfoSubType";
         this.nodeInfoSubType.Click += new System.EventHandler(this.nodeInfoSubType_Click);
         // 
         // nodeInfoType
         // 
         this.nodeInfoType.AutoSize = true;
         this.nodeInfoType.Location = new System.Drawing.Point(237, 13);
         this.nodeInfoType.Name = "nodeInfoType";
         this.nodeInfoType.Size = new System.Drawing.Size(73, 13);
         this.nodeInfoType.TabIndex = 2;
         this.nodeInfoType.Text = "nodeInfoType";
         // 
         // nodeInfoName
         // 
         this.nodeInfoName.AutoSize = true;
         this.nodeInfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.nodeInfoName.Location = new System.Drawing.Point(14, 9);
         this.nodeInfoName.Name = "nodeInfoName";
         this.nodeInfoName.Size = new System.Drawing.Size(97, 17);
         this.nodeInfoName.TabIndex = 0;
         this.nodeInfoName.Text = "Select a Node";
         // 
         // encounterTreeView
         // 
         this.encounterTreeView.Dock = System.Windows.Forms.DockStyle.Left;
         this.encounterTreeView.FullRowSelect = true;
         this.encounterTreeView.HideSelection = false;
         this.encounterTreeView.Location = new System.Drawing.Point(3, 28);
         this.encounterTreeView.Name = "encounterTreeView";
         this.encounterTreeView.PathSeparator = "/";
         this.encounterTreeView.Size = new System.Drawing.Size(250, 524);
         this.encounterTreeView.TabIndex = 0;
         this.encounterTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.encounterTreeView_AfterSelect);
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripSaveButton});
         this.toolStrip1.Location = new System.Drawing.Point(3, 3);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(1109, 25);
         this.toolStrip1.TabIndex = 4;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // toolstripSaveButton
         // 
         this.toolstripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolstripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripSaveButton.Image")));
         this.toolstripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolstripSaveButton.Name = "toolstripSaveButton";
         this.toolstripSaveButton.Size = new System.Drawing.Size(23, 22);
         this.toolstripSaveButton.Text = "Save modified files";
         this.toolstripSaveButton.Click += new System.EventHandler(this.toolstripSaveButton_Click);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
         // 
         // saveNewEncounterNodeDialog
         // 
         this.saveNewEncounterNodeDialog.DefaultExt = "json";
         this.saveNewEncounterNodeDialog.Filter = "Json Files|*.json";
         this.saveNewEncounterNodeDialog.RestoreDirectory = true;
         this.saveNewEncounterNodeDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveNewEncounterNodeDialog_FileOk);
         // 
         // modsFolderBrowserDialog
         // 
         this.modsFolderBrowserDialog.Description = "Stonehearth Mods Root Directory";
         this.modsFolderBrowserDialog.ShowNewFolderButton = false;
         // 
         // mainFormMenu
         // 
         this.mainFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
         this.mainFormMenu.Location = new System.Drawing.Point(0, 0);
         this.mainFormMenu.Name = "mainFormMenu";
         this.mainFormMenu.Size = new System.Drawing.Size(1123, 24);
         this.mainFormMenu.TabIndex = 2;
         this.mainFormMenu.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.changeModDirectoryToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // saveAllToolStripMenuItem
         // 
         this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
         this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
         this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
         this.saveAllToolStripMenuItem.Text = "Save All";
         this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
         // 
         // reloadToolStripMenuItem
         // 
         this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
         this.reloadToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
         this.reloadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
         this.reloadToolStripMenuItem.Text = "Reload";
         this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
         // 
         // changeModDirectoryToolStripMenuItem
         // 
         this.changeModDirectoryToolStripMenuItem.Name = "changeModDirectoryToolStripMenuItem";
         this.changeModDirectoryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
         this.changeModDirectoryToolStripMenuItem.Text = "Change Mod Directory";
         // 
         // StonehearthEditor
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.ClientSize = new System.Drawing.Size(1123, 605);
         this.Controls.Add(this.tabControl);
         this.Controls.Add(this.mainFormMenu);
         this.KeyPreview = true;
         this.MainMenuStrip = this.mainFormMenu;
         this.Name = "StonehearthEditor";
         this.Text = "Stonehearth Editor";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StonehearthEditor_KeyDown);
         this.aliasContextMenu.ResumeLayout(false);
         this.tabControl.ResumeLayout(false);
         this.manifestTab.ResumeLayout(false);
         this.splitContainer2.Panel1.ResumeLayout(false);
         this.splitContainer2.Panel2.ResumeLayout(false);
         this.splitContainer2.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         this.searchPanel.ResumeLayout(false);
         this.searchPanel.PerformLayout();
         this.splitContainer3.Panel1.ResumeLayout(false);
         this.splitContainer3.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
         this.splitContainer3.ResumeLayout(false);
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.iconView)).EndInit();
         this.encounterTab.ResumeLayout(false);
         this.encounterTab.PerformLayout();
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.encounterTabRightSide.ResumeLayout(false);
         this.encounterTabRightSide.PerformLayout();
         this.encounterGraphContextMenu.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.nodeInfoPanel.ResumeLayout(false);
         this.nodeInfoPanel.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.mainFormMenu.ResumeLayout(false);
         this.mainFormMenu.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.TreeView treeView;
      private System.Windows.Forms.ContextMenuStrip aliasContextMenu;
      private System.Windows.Forms.ToolStripMenuItem aliasContextDuplicate;
      private System.Windows.Forms.Label selectedFilePathLabel;
      private System.Windows.Forms.ImageList manifestImageList;
      private System.Windows.Forms.TabControl tabControl;
      private System.Windows.Forms.TabPage manifestTab;
      private System.Windows.Forms.TabPage encounterTab;
      private System.Windows.Forms.TreeView encounterTreeView;
      private System.Windows.Forms.Panel encounterTabRightSide;
      private Microsoft.Msagl.GraphViewerGdi.GViewer graphViewer;
      private System.Windows.Forms.Panel nodeInfoPanel;
      private System.Windows.Forms.Label nodeInfoName;
      private System.Windows.Forms.Label nodeInfoSubType;
      private System.Windows.Forms.Label nodeInfoType;
      private System.Windows.Forms.TextBox encounterRightSideFilePath;
      private System.Windows.Forms.RichTextBox nodeInfoJsonPreview;
      private System.Windows.Forms.ContextMenuStrip encounterGraphContextMenu;
      private System.Windows.Forms.ToolStripMenuItem copyGameMasterNode;
      private System.Windows.Forms.ToolStripMenuItem addNewGameMasterNode;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton toolstripSaveButton;
      private System.Windows.Forms.ToolTip i18nTooltip;
      private System.Windows.Forms.SaveFileDialog saveNewEncounterNodeDialog;
      private System.Windows.Forms.FolderBrowserDialog modsFolderBrowserDialog;
      private System.Windows.Forms.Button openEncounterFileButton;
      private System.Windows.Forms.ToolStripMenuItem deleteNodeToolStripMenuItem;
      private System.Windows.Forms.TextBox searchBox;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.Button searchButton;
      private System.Windows.Forms.Panel searchPanel;
      private System.Windows.Forms.ListView dependenciesListView;
      private System.Windows.Forms.SplitContainer splitContainer3;
      private System.Windows.Forms.TabControl filePreviewTabs;
      private System.Windows.Forms.MenuStrip mainFormMenu;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem changeModDirectoryToolStripMenuItem;
      private System.Windows.Forms.FlowLayoutPanel openFileButtonPanel;
      private System.Windows.Forms.PictureBox iconView;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Label dependenciesLabel;
   }
}

