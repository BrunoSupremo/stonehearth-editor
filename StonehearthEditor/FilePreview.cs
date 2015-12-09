﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StonehearthEditor
{
   public partial class FilePreview : UserControl, AliasSelectionDialog.IDialogCallback
   {
      private FileData mFileData;
      private int mI18nTooltipLine = -1;
      public FilePreview(FileData fileData)
      {
         mFileData = fileData;
         InitializeComponent();
         textBox.Text = mFileData.FlatFileData;
      }

      private void textBox_Leave(object sender, EventArgs e)
      {
         mFileData.TrySetFlatFileData(textBox.Text);
      }

      private void textBox_MouseMove(object sender, MouseEventArgs e)
      {
         int charIndex = textBox.GetCharIndexFromPosition(e.Location);
         int line = textBox.GetLineFromCharIndex(charIndex);

         if (textBox.Lines.Length <= line)
         {
            return;
         }
         if (mI18nTooltipLine == line)
         {
            return;
         }
         i18nTooltip.Hide(textBox);

         mI18nTooltipLine = line;
         string lineString = textBox.Lines[line];
         Regex matcher = new Regex(@"i18n\(([^)]+)\)");
         Match locMatch = matcher.Match(lineString);
         if (locMatch.Success)
         {
            string translated = ModuleDataManager.GetInstance().LocalizeString(locMatch.Groups[1].Value);
            translated = JsonHelper.WordWrap(translated, 100);
            i18nTooltip.Show(translated, textBox, e.Location);
         }
         else
         {
            i18nTooltip.Hide(textBox);
         }
      }
      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Save();
      }

      private void Save()
      {
         if (!mFileData.TrySetFlatFileData(textBox.Text))
         {
            MessageBox.Show("Unable to save " + mFileData.FileName + ". Invalid Json");
            return;
         }
         mFileData.TrySaveFile();
         TabPage parentControl = Parent as TabPage;
         if (parentControl != null)
         {
            int caretPosition = textBox.SelectionStart;
            textBox.Text = mFileData.FlatFileData;
            textBox.SelectionStart = caretPosition;
            textBox.ScrollToCaret();
            parentControl.Text = mFileData.FileName;
         }
      }

      private void textBox_KeyDown(object sender, KeyEventArgs e)
      {
         TabPage parentControl = Parent as TabPage;
         if (parentControl != null)
         {
            if (!mFileData.FlatFileData.Equals(textBox.Text))
            {
               parentControl.Text = mFileData.FileName + "*";
            }
         }
         if (e.KeyCode == Keys.Tab)
         {
            e.Handled = true;
         }
      }

      private void openFile_Click(object sender, EventArgs e)
      {
         System.Diagnostics.Process.Start(mFileData.Path);
      }

      private void openFolder_Click(object sender, EventArgs e)
      {
         System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(mFileData.Path));
      }

      private void saveFile_Click(object sender, EventArgs e)
      {
         Save();
      }

      private void localizeFile_Click(object sender, EventArgs e)
      {
         /*
         ProcessStartInfo start = new ProcessStartInfo();
         start.FileName = "my/full/path/to/python.exe";
         start.Arguments = string.Format("{0} {1}", cmd, args);
         start.UseShellExecute = false;
         start.RedirectStandardOutput = true;
         using (Process process = Process.Start(start))
         {
            using (StreamReader reader = process.StandardOutput)
            {
               string result = reader.ReadToEnd();
               Console.Write(result);
            }
         }*/
      }
      
      protected override bool ProcessDialogKey(Keys keyData)
      {
         if (keyData == Keys.Tab)
         {
            return false;
         }
         return base.ProcessDialogKey(keyData);
      }

      protected override bool ProcessTabKey(bool forward)
      {
         return false;
      }

      private void insertAliasToolStripMenuItem_Click(object sender, EventArgs e)
      {
         AliasSelectionDialog aliasDialog = new AliasSelectionDialog(this);
         aliasDialog.ShowDialog();
      }

      public bool OnAccept(HashSet<string> aliases)
      {
         StringBuilder aliasInsert = new StringBuilder();
         bool isFirst = true;
         foreach(string alias in aliases)
         {
            if (!isFirst)
            {
               aliasInsert.AppendLine(",");
            }
            isFirst = false;
            aliasInsert.Append('"' + alias + '"');
         }
         textBox.SelectionLength = 1;
         textBox.SelectedText = aliasInsert.ToString();
         return true;
      }

      public void onCancelled()
      {
         
      }
   }
}
