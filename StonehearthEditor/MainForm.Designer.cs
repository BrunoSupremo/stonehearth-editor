﻿namespace StonehearthEditor
{
   partial class MainForm
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
         this.tabControl = new System.Windows.Forms.TabControl();
         this.manifestTab = new System.Windows.Forms.TabPage();
         this.encounterTab = new System.Windows.Forms.TabPage();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.modsFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
         this.mainFormMenu = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.changeModDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.manifestView = new StonehearthEditor.ManifestView();
         this.encounterDesignerView = new StonehearthEditor.EncounterDesignerView();
         this.tabControl.SuspendLayout();
         this.manifestTab.SuspendLayout();
         this.encounterTab.SuspendLayout();
         this.mainFormMenu.SuspendLayout();
         this.SuspendLayout();
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
         this.manifestTab.Controls.Add(this.manifestView);
         this.manifestTab.Location = new System.Drawing.Point(4, 22);
         this.manifestTab.Name = "manifestTab";
         this.manifestTab.Padding = new System.Windows.Forms.Padding(3);
         this.manifestTab.Size = new System.Drawing.Size(1115, 555);
         this.manifestTab.TabIndex = 0;
         this.manifestTab.Text = "Manifest";
         this.manifestTab.UseVisualStyleBackColor = true;
         // 
         // encounterTab
         // 
         this.encounterTab.Controls.Add(this.encounterDesignerView);
         this.encounterTab.Location = new System.Drawing.Point(4, 22);
         this.encounterTab.Name = "encounterTab";
         this.encounterTab.Padding = new System.Windows.Forms.Padding(3);
         this.encounterTab.Size = new System.Drawing.Size(1115, 555);
         this.encounterTab.TabIndex = 1;
         this.encounterTab.Text = "Encounter Designer";
         this.encounterTab.UseVisualStyleBackColor = true;
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
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
         // manifestView
         // 
         this.manifestView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.manifestView.Location = new System.Drawing.Point(3, 3);
         this.manifestView.Name = "manifestView";
         this.manifestView.Size = new System.Drawing.Size(1109, 549);
         this.manifestView.TabIndex = 0;
         // 
         // encounterDesignerView
         // 
         this.encounterDesignerView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.encounterDesignerView.Location = new System.Drawing.Point(3, 3);
         this.encounterDesignerView.Name = "encounterDesignerView";
         this.encounterDesignerView.Size = new System.Drawing.Size(1109, 549);
         this.encounterDesignerView.TabIndex = 0;
         // 
         // MainForm
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
         this.ClientSize = new System.Drawing.Size(1123, 605);
         this.Controls.Add(this.tabControl);
         this.Controls.Add(this.mainFormMenu);
         this.KeyPreview = true;
         this.MainMenuStrip = this.mainFormMenu;
         this.Name = "MainForm";
         this.Text = "Stonehearth Editor";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.Resize += new System.EventHandler(this.MainForm_Resize);
         this.tabControl.ResumeLayout(false);
         this.manifestTab.ResumeLayout(false);
         this.encounterTab.ResumeLayout(false);
         this.mainFormMenu.ResumeLayout(false);
         this.mainFormMenu.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.TabControl tabControl;
      private System.Windows.Forms.TabPage encounterTab;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.FolderBrowserDialog modsFolderBrowserDialog;
      private System.Windows.Forms.MenuStrip mainFormMenu;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem changeModDirectoryToolStripMenuItem;
      private System.Windows.Forms.TabPage manifestTab;
      private ManifestView manifestView;
      private EncounterDesignerView encounterDesignerView;
   }
}

