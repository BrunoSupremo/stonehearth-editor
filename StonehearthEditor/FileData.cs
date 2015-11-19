﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonehearthEditor
{
   public abstract class FileData
   {
      private string mFlatFileData;
      protected bool mIsModified = false;
      public abstract List<ModuleFile> LinkedAliases { get; }
      public abstract List<string> LinkedFilePaths { get; }

      public abstract List<FileData> OpenedFiles { get; }
      public abstract List<FileData> RelatedFiles { get; }

      public abstract string Path { get; }

      public string FileName
      {
         get { return System.IO.Path.GetFileNameWithoutExtension(Path); }
      }
      public bool IsModified
      {
         get { return mIsModified; }
      }
      public abstract bool UpdateTreeNode(TreeNode node, string filter);
      public void TrySetFlatFileData(string newData)
      {
         if (TryChangeFlatFileData(newData))
         {
            mFlatFileData = newData;
            mIsModified = true;
         }
      }
      public void TrySaveFile() {
         if (mIsModified)
         {
            try
            {
               using (StreamWriter wr = new StreamWriter(Path, false, new UTF8Encoding(false)))
               {
                  wr.Write(FlatFileData);
               }
               mIsModified = false;
            }
            catch (Exception e)
            {
               Console.WriteLine("Could not write to file " + Path + " because of exception: " + e.Message);
            }
         }
      }
      public void FillDependencyListItems(ListView listView)
      {
         listView.Items.Clear();
         foreach(string dependency in GetDependencySet())
         {
            listView.Items.Add(dependency);
         }
      }

      protected HashSet<string> GetDependencySet()
      {
         HashSet<string> dependenciesSet = new HashSet<string>();
         foreach (ModuleFile dependency in LinkedAliases)
         {
            string alias = dependency.Module.Name + ":" + dependency.Name;
            if (!dependenciesSet.Contains(alias))
            {
               dependenciesSet.Add(alias);
            }
         }
         foreach (string filePath in LinkedFilePaths)
         {
            string filePathWithoutBase = filePath.Replace(ModuleDataManager.GetInstance().ModsDirectoryPath, "");
            if (!dependenciesSet.Contains(filePathWithoutBase))
            {
               dependenciesSet.Add(filePathWithoutBase);
            }
         }
         return dependenciesSet;
      }

      public void Load()
      {
         if (System.IO.File.Exists(Path))
         {
            using (StreamReader sr = new StreamReader(Path, Encoding.UTF8))
            {
               mFlatFileData = sr.ReadToEnd();
               sr.BaseStream.Position = 0;
               sr.DiscardBufferedData();
               LoadInternal();
            }
         }
      }
      public string FlatFileData
      {
         get { return mFlatFileData; }
      }

      // custom load call
      protected virtual void LoadInternal() { }

      protected virtual bool TryChangeFlatFileData(string newData)
      {
         return true;
      }
      protected FileData GetLinkedFileData(string path)
      {
         foreach(FileData data in OpenedFiles)
         {
            if (data.Path == path)
            {
               return data;
            }
         }
         foreach (FileData data in RelatedFiles)
         {
            if (data.Path == path)
            {
               return data;
            }
         }
         return null;
      }

      public virtual bool ShouldCloneDependency(string dependencyName, string oldName)
      {
         return dependencyName.Contains(oldName);
      }

      public virtual string GetNameForCloning()
      {
         return FileName;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="newPath"></param>
      /// <param name="oldName"></param>
      /// <param name="newFileName"></param>
      /// <param name="alreadyCloned"></param>
      /// <param name="execute">whether to actual execute the clone. otherwise, this is just a preview</param>
      /// <returns></returns>
      public virtual bool Clone(string newPath, string oldName, string newFileName, HashSet<string> alreadyCloned, bool execute)
      {
         //Ensure directory exists
         string directory = System.IO.Path.GetDirectoryName(newPath);
         alreadyCloned.Add(newPath);
         if (execute)
         {
            System.IO.Directory.CreateDirectory(directory);
         }
         // Figure out what dependency files need to exist
         foreach(string dependency in GetDependencySet())
         {
            if (ShouldCloneDependency(dependency, oldName))
            {
               // We want to clone this dependency
               if (dependency.Contains(":"))
               {
                  // this dependency is an alias. Clone the alias.
                  ModuleFile linkedAlias = ModuleDataManager.GetInstance().GetModuleFile(dependency);
                  if (linkedAlias != null)
                  {
                     string aliasNewName = dependency.Replace(oldName, newFileName);
                     if (!alreadyCloned.Contains(aliasNewName))
                     {
                        alreadyCloned.Add(aliasNewName);
                        linkedAlias.Clone(oldName, newFileName, alreadyCloned, execute);
                     }
                  }
               } else
               {
                  // This dependency is a flat file.
                  string linkedPath = ModuleDataManager.GetInstance().ModsDirectoryPath + dependency;
                  string newDependencyPathName = newFileName;
                  string newDependencyPath = ModuleDataManager.GetInstance().ModsDirectoryPath + dependency.Replace(oldName, newDependencyPathName);
                  if (!alreadyCloned.Contains(newDependencyPath))
                  {
                     alreadyCloned.Add(newDependencyPath);
                     FileData linkedFile = GetLinkedFileData(linkedPath);
                     if (linkedFile != null)
                     {
                        linkedFile.Clone(newDependencyPath, oldName, newDependencyPathName, alreadyCloned, execute);
                     }
                     else
                     {
                        string extension = System.IO.Path.GetExtension(newDependencyPath);
                        string qmo = linkedPath.Replace(".qb", ".qmo");
                        string newQmo = newDependencyPath.Replace(".qb", ".qmo");
                        if (System.IO.File.Exists(qmo))
                        {
                           alreadyCloned.Add(newQmo);
                        }
                        if (execute)
                        {
                           string newDependencyDirectory = System.IO.Path.GetDirectoryName(newDependencyPath);
                           System.IO.Directory.CreateDirectory(newDependencyDirectory);
                           System.IO.File.Copy(linkedPath, newDependencyPath);
                           if (extension == ".qb")
                           {
                              if (System.IO.File.Exists(qmo))
                              {
                                 System.IO.File.Copy(qmo, newQmo);
                              }
                           }
                        }
                     }
                  }
               }
            }
         }

         if (execute)
         {
            string newFlatFile = FlatFileData.Replace(oldName, newFileName);
            using (StreamWriter wr = new StreamWriter(newPath, false, new UTF8Encoding(false)))
            {
               wr.Write(newFlatFile);
            }
         }
         return true;
      }
   }
}
