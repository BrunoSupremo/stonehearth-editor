﻿namespace StonehearthEditor
{
    partial class EffectsEditorView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EffectsEditorView));
            this.effectsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeViewTabControl = new System.Windows.Forms.TabControl();
            this.cubemittersTreeViewTab = new System.Windows.Forms.TabPage();
            this.cubemittersTreeView = new System.Windows.Forms.TreeView();
            this.lightsTreeViewTab = new System.Windows.Forms.TabPage();
            this.lightsTreeView = new System.Windows.Forms.TreeView();
            this.effectsTreeViewTab = new System.Windows.Forms.TabPage();
            this.effectsEditorTreeView = new System.Windows.Forms.TreeView();
            this.effectsSplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.filePreviewTabs = new System.Windows.Forms.TabControl();
            this.effectsBrowserPanel = new System.Windows.Forms.Panel();
            this.effectsToolStrip = new System.Windows.Forms.ToolStrip();
            this.newFileButton = new System.Windows.Forms.ToolStripButton();
            this.effectsOpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.cefDevToolsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openEffectsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsEditorContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveEffectsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.helpButton = new System.Windows.Forms.Button();
            this.skySettingsTreeViewTab = new System.Windows.Forms.TabPage();
            this.skySettingsTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer)).BeginInit();
            this.effectsSplitContainer.Panel1.SuspendLayout();
            this.effectsSplitContainer.Panel2.SuspendLayout();
            this.effectsSplitContainer.SuspendLayout();
            this.treeViewTabControl.SuspendLayout();
            this.cubemittersTreeViewTab.SuspendLayout();
            this.lightsTreeViewTab.SuspendLayout();
            this.effectsTreeViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer2)).BeginInit();
            this.effectsSplitContainer2.Panel1.SuspendLayout();
            this.effectsSplitContainer2.Panel2.SuspendLayout();
            this.effectsSplitContainer2.SuspendLayout();
            this.effectsToolStrip.SuspendLayout();
            this.effectsEditorContextMenuStrip.SuspendLayout();
            this.skySettingsTreeViewTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // effectsSplitContainer
            // 
            this.effectsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effectsSplitContainer.Location = new System.Drawing.Point(0, 27);
            this.effectsSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.effectsSplitContainer.Name = "effectsSplitContainer";
            // 
            // effectsSplitContainer.Panel1
            // 
            this.effectsSplitContainer.Panel1.Controls.Add(this.treeViewTabControl);
            // 
            // effectsSplitContainer.Panel2
            // 
            this.effectsSplitContainer.Panel2.Controls.Add(this.effectsSplitContainer2);
            this.effectsSplitContainer.Size = new System.Drawing.Size(1008, 678);
            this.effectsSplitContainer.SplitterDistance = 289;
            this.effectsSplitContainer.SplitterWidth = 5;
            this.effectsSplitContainer.TabIndex = 1;
            // 
            // treeViewTabControl
            // 
            this.treeViewTabControl.Controls.Add(this.cubemittersTreeViewTab);
            this.treeViewTabControl.Controls.Add(this.lightsTreeViewTab);
            this.treeViewTabControl.Controls.Add(this.effectsTreeViewTab);
            this.treeViewTabControl.Controls.Add(this.skySettingsTreeViewTab);
            this.treeViewTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTabControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewTabControl.Name = "treeViewTabControl";
            this.treeViewTabControl.SelectedIndex = 0;
            this.treeViewTabControl.Size = new System.Drawing.Size(289, 678);
            this.treeViewTabControl.TabIndex = 0;
            // 
            // cubemittersTreeViewTab
            // 
            this.cubemittersTreeViewTab.Controls.Add(this.cubemittersTreeView);
            this.cubemittersTreeViewTab.Location = new System.Drawing.Point(4, 25);
            this.cubemittersTreeViewTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubemittersTreeViewTab.Name = "cubemittersTreeViewTab";
            this.cubemittersTreeViewTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubemittersTreeViewTab.Size = new System.Drawing.Size(281, 649);
            this.cubemittersTreeViewTab.TabIndex = 1;
            this.cubemittersTreeViewTab.Text = "Cubemitters";
            this.cubemittersTreeViewTab.UseVisualStyleBackColor = true;
            // 
            // cubemittersTreeView
            // 
            this.cubemittersTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubemittersTreeView.FullRowSelect = true;
            this.cubemittersTreeView.HideSelection = false;
            this.cubemittersTreeView.Location = new System.Drawing.Point(4, 4);
            this.cubemittersTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cubemittersTreeView.Name = "cubemittersTreeView";
            this.cubemittersTreeView.PathSeparator = "/";
            this.cubemittersTreeView.Size = new System.Drawing.Size(273, 641);
            this.cubemittersTreeView.TabIndex = 1;
            this.cubemittersTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cubemittersTreeView_AfterSelect);
            this.cubemittersTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cubemittersTreeView_MouseClick);
            // 
            // lightsTreeViewTab
            // 
            this.lightsTreeViewTab.Controls.Add(this.lightsTreeView);
            this.lightsTreeViewTab.Location = new System.Drawing.Point(4, 25);
            this.lightsTreeViewTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightsTreeViewTab.Name = "lightsTreeViewTab";
            this.lightsTreeViewTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightsTreeViewTab.Size = new System.Drawing.Size(281, 649);
            this.lightsTreeViewTab.TabIndex = 2;
            this.lightsTreeViewTab.Text = "Lights";
            this.lightsTreeViewTab.UseVisualStyleBackColor = true;
            // 
            // lightsTreeView
            // 
            this.lightsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightsTreeView.HideSelection = false;
            this.lightsTreeView.Location = new System.Drawing.Point(4, 4);
            this.lightsTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightsTreeView.Name = "lightsTreeView";
            this.lightsTreeView.Size = new System.Drawing.Size(273, 641);
            this.lightsTreeView.TabIndex = 0;
            this.lightsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lightsTreeView_AfterSelect);
            this.lightsTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lightsTreeView_MouseClick);
            // 
            // effectsTreeViewTab
            // 
            this.effectsTreeViewTab.Controls.Add(this.effectsEditorTreeView);
            this.effectsTreeViewTab.Location = new System.Drawing.Point(4, 25);
            this.effectsTreeViewTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.effectsTreeViewTab.Name = "effectsTreeViewTab";
            this.effectsTreeViewTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.effectsTreeViewTab.Size = new System.Drawing.Size(281, 649);
            this.effectsTreeViewTab.TabIndex = 0;
            this.effectsTreeViewTab.Text = "Effects";
            this.effectsTreeViewTab.UseVisualStyleBackColor = true;
            // 
            // effectsEditorTreeView
            // 
            this.effectsEditorTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effectsEditorTreeView.FullRowSelect = true;
            this.effectsEditorTreeView.HideSelection = false;
            this.effectsEditorTreeView.Location = new System.Drawing.Point(4, 4);
            this.effectsEditorTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.effectsEditorTreeView.Name = "effectsEditorTreeView";
            this.effectsEditorTreeView.Size = new System.Drawing.Size(273, 641);
            this.effectsEditorTreeView.TabIndex = 0;
            this.effectsEditorTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.effectsEditorTreeView_AfterSelect);
            this.effectsEditorTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.effectsEditorTreeView_MouseClick);
            // 
            // effectsSplitContainer2
            // 
            this.effectsSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effectsSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.effectsSplitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.effectsSplitContainer2.Name = "effectsSplitContainer2";
            // 
            // effectsSplitContainer2.Panel1
            // 
            this.effectsSplitContainer2.Panel1.Controls.Add(this.filePreviewTabs);
            // 
            // effectsSplitContainer2.Panel2
            // 
            this.effectsSplitContainer2.Panel2.Controls.Add(this.effectsBrowserPanel);
            this.effectsSplitContainer2.Size = new System.Drawing.Size(714, 678);
            this.effectsSplitContainer2.SplitterDistance = 238;
            this.effectsSplitContainer2.SplitterWidth = 5;
            this.effectsSplitContainer2.TabIndex = 0;
            // 
            // filePreviewTabs
            // 
            this.filePreviewTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePreviewTabs.Location = new System.Drawing.Point(0, 0);
            this.filePreviewTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filePreviewTabs.Name = "filePreviewTabs";
            this.filePreviewTabs.SelectedIndex = 0;
            this.filePreviewTabs.Size = new System.Drawing.Size(238, 678);
            this.filePreviewTabs.TabIndex = 3;
            // 
            // effectsBrowserPanel
            // 
            this.effectsBrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effectsBrowserPanel.Location = new System.Drawing.Point(0, 0);
            this.effectsBrowserPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.effectsBrowserPanel.Name = "effectsBrowserPanel";
            this.effectsBrowserPanel.Size = new System.Drawing.Size(471, 678);
            this.effectsBrowserPanel.TabIndex = 0;
            // 
            // effectsToolStrip
            // 
            this.effectsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.effectsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileButton,
            this.effectsOpenFileButton,
            this.cefDevToolsButton,
            this.toolStripButton1});
            this.effectsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.effectsToolStrip.Name = "effectsToolStrip";
            this.effectsToolStrip.Size = new System.Drawing.Size(1008, 27);
            this.effectsToolStrip.TabIndex = 2;
            this.effectsToolStrip.Text = "Effects Tool Strip";
            // 
            // newFileButton
            // 
            this.newFileButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFileButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(132, 24);
            this.newFileButton.Text = "+ New Effects File";
            this.newFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.newFileButton.ToolTipText = "Not yet implemented!";
            this.newFileButton.Click += new System.EventHandler(this.newFileButton_Click);
            // 
            // effectsOpenFileButton
            // 
            this.effectsOpenFileButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.effectsOpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.effectsOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("effectsOpenFileButton.Image")));
            this.effectsOpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.effectsOpenFileButton.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.effectsOpenFileButton.Name = "effectsOpenFileButton";
            this.effectsOpenFileButton.Size = new System.Drawing.Size(76, 24);
            this.effectsOpenFileButton.Text = "Open File";
            this.effectsOpenFileButton.Click += new System.EventHandler(this.effectsOpenFileButton_Click);
            // 
            // cefDevToolsButton
            // 
            this.cefDevToolsButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cefDevToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cefDevToolsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cefDevToolsButton.Image = ((System.Drawing.Image)(resources.GetObject("cefDevToolsButton.Image")));
            this.cefDevToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cefDevToolsButton.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.cefDevToolsButton.Name = "cefDevToolsButton";
            this.cefDevToolsButton.Size = new System.Drawing.Size(104, 24);
            this.cefDevToolsButton.Text = "Cef Dev Tools";
            this.cefDevToolsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cefDevToolsButton.Click += new System.EventHandler(this.cefDevToolsButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 24);
            this.toolStripButton1.Text = "Cef Reload";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openEffectsFileDialog
            // 
            this.openEffectsFileDialog.FileName = "openEffectsFileDialog";
            this.openEffectsFileDialog.Filter = "JSON Files|*.json|Lua Files|*.lua";
            this.openEffectsFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openEffectsFileDialog_FileOk);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.cloneToolStripMenuItem.Text = "Clone";
            this.cloneToolStripMenuItem.Click += new System.EventHandler(this.cloneToolStripMenuItem_Click);
            // 
            // effectsEditorContextMenuStrip
            // 
            this.effectsEditorContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.effectsEditorContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cloneToolStripMenuItem});
            this.effectsEditorContextMenuStrip.Name = "effectsEditorContextMenuStrip";
            this.effectsEditorContextMenuStrip.Size = new System.Drawing.Size(117, 28);
            // 
            // saveEffectsFileDialog
            // 
            this.saveEffectsFileDialog.Filter = "JSON Files|*.json|Lua Files|*.lua";
            this.saveEffectsFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveEffectsFileDialog_FileOk);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(929, 0);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(61, 31);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // skySettingsTreeViewTab
            // 
            this.skySettingsTreeViewTab.Controls.Add(this.skySettingsTreeView);
            this.skySettingsTreeViewTab.Location = new System.Drawing.Point(4, 25);
            this.skySettingsTreeViewTab.Name = "skySettingsTreeViewTab";
            this.skySettingsTreeViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.skySettingsTreeViewTab.Size = new System.Drawing.Size(281, 649);
            this.skySettingsTreeViewTab.TabIndex = 3;
            this.skySettingsTreeViewTab.Text = "Skies";
            this.skySettingsTreeViewTab.UseVisualStyleBackColor = true;
            // 
            // skySettingsTreeView
            // 
            this.skySettingsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skySettingsTreeView.FullRowSelect = true;
            this.skySettingsTreeView.HideSelection = false;
            this.skySettingsTreeView.Location = new System.Drawing.Point(3, 3);
            this.skySettingsTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.skySettingsTreeView.Name = "skySettingsTreeView";
            this.skySettingsTreeView.Size = new System.Drawing.Size(275, 643);
            this.skySettingsTreeView.TabIndex = 1;
            this.skySettingsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.skySettingsTreeView_AfterSelect);
            this.skySettingsTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.skySettingsTreeView_MouseClick);
            // 
            // EffectsEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.effectsSplitContainer);
            this.Controls.Add(this.effectsToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EffectsEditorView";
            this.Size = new System.Drawing.Size(1008, 705);
            this.effectsSplitContainer.Panel1.ResumeLayout(false);
            this.effectsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer)).EndInit();
            this.effectsSplitContainer.ResumeLayout(false);
            this.treeViewTabControl.ResumeLayout(false);
            this.cubemittersTreeViewTab.ResumeLayout(false);
            this.lightsTreeViewTab.ResumeLayout(false);
            this.effectsTreeViewTab.ResumeLayout(false);
            this.effectsSplitContainer2.Panel1.ResumeLayout(false);
            this.effectsSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.effectsSplitContainer2)).EndInit();
            this.effectsSplitContainer2.ResumeLayout(false);
            this.effectsToolStrip.ResumeLayout(false);
            this.effectsToolStrip.PerformLayout();
            this.effectsEditorContextMenuStrip.ResumeLayout(false);
            this.skySettingsTreeViewTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer effectsSplitContainer;
        private System.Windows.Forms.SplitContainer effectsSplitContainer2;
        private System.Windows.Forms.TabControl filePreviewTabs;
        private System.Windows.Forms.ToolStrip effectsToolStrip;
        private System.Windows.Forms.ToolStripButton newFileButton;
        private System.Windows.Forms.ToolStripButton effectsOpenFileButton;
        private System.Windows.Forms.OpenFileDialog openEffectsFileDialog;
        private System.Windows.Forms.TreeView effectsEditorTreeView;
        private System.Windows.Forms.TabControl treeViewTabControl;
        private System.Windows.Forms.TabPage cubemittersTreeViewTab;
        private System.Windows.Forms.TreeView cubemittersTreeView;
        private System.Windows.Forms.TabPage effectsTreeViewTab;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip effectsEditorContextMenuStrip;
        private System.Windows.Forms.SaveFileDialog saveEffectsFileDialog;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel effectsBrowserPanel;
        private System.Windows.Forms.ToolStripButton cefDevToolsButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
      private System.Windows.Forms.TabPage lightsTreeViewTab;
      private System.Windows.Forms.TreeView lightsTreeView;
        private System.Windows.Forms.TabPage skySettingsTreeViewTab;
        private System.Windows.Forms.TreeView skySettingsTreeView;
    }
}
