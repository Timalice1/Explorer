namespace Lab2 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Item1");
            this.drivesTree = new System.Windows.Forms.TreeView();
            this.DirName = new System.Windows.Forms.Label();
            this.browserString = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.driveInfoPanel = new System.Windows.Forms.TabPage();
            this.driveVolumeLabel = new System.Windows.Forms.Label();
            this.driveTypeLabel = new System.Windows.Forms.Label();
            this.driveFormatLabel = new System.Windows.Forms.Label();
            this.freeSpaceLabel = new System.Windows.Forms.Label();
            this.totalSpaceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dirInfoPanel = new System.Windows.Forms.TabPage();
            this.dirList = new System.Windows.Forms.ListView();
            this.listViewItemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItem3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirListMenuStrip = new System.Windows.Forms.MenuStrip();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.driveInfoPanel.SuspendLayout();
            this.dirInfoPanel.SuspendLayout();
            this.listViewItemContextMenu.SuspendLayout();
            this.dirListMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // drivesTree
            // 
            this.drivesTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drivesTree.Location = new System.Drawing.Point(14, 12);
            this.drivesTree.Name = "drivesTree";
            this.drivesTree.Size = new System.Drawing.Size(177, 343);
            this.drivesTree.TabIndex = 0;
            this.drivesTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.driverTree_NodeMouseClick);
            // 
            // DirName
            // 
            this.DirName.AutoSize = true;
            this.DirName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirName.Location = new System.Drawing.Point(197, 35);
            this.DirName.Name = "DirName";
            this.DirName.Size = new System.Drawing.Size(116, 20);
            this.DirName.TabIndex = 1;
            this.DirName.Text = "Directory name";
            // 
            // browserString
            // 
            this.browserString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browserString.ForeColor = System.Drawing.SystemColors.WindowText;
            this.browserString.Location = new System.Drawing.Point(201, 12);
            this.browserString.Name = "browserString";
            this.browserString.Size = new System.Drawing.Size(378, 20);
            this.browserString.TabIndex = 2;
            this.browserString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.browserString_KeyUp);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(585, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(53, 21);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.driveInfoPanel);
            this.tabControl1.Controls.Add(this.dirInfoPanel);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(197, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 296);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabStop = false;
            // 
            // driveInfoPanel
            // 
            this.driveInfoPanel.BackColor = System.Drawing.SystemColors.Window;
            this.driveInfoPanel.Controls.Add(this.driveVolumeLabel);
            this.driveInfoPanel.Controls.Add(this.driveTypeLabel);
            this.driveInfoPanel.Controls.Add(this.driveFormatLabel);
            this.driveInfoPanel.Controls.Add(this.freeSpaceLabel);
            this.driveInfoPanel.Controls.Add(this.totalSpaceLabel);
            this.driveInfoPanel.Controls.Add(this.label5);
            this.driveInfoPanel.Controls.Add(this.label4);
            this.driveInfoPanel.Controls.Add(this.label3);
            this.driveInfoPanel.Controls.Add(this.label2);
            this.driveInfoPanel.Controls.Add(this.label1);
            this.driveInfoPanel.Location = new System.Drawing.Point(4, 5);
            this.driveInfoPanel.Name = "driveInfoPanel";
            this.driveInfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.driveInfoPanel.Size = new System.Drawing.Size(436, 266);
            this.driveInfoPanel.TabIndex = 0;
            this.driveInfoPanel.Text = "tabPage1";
            // 
            // driveVolumeLabel
            // 
            this.driveVolumeLabel.AutoSize = true;
            this.driveVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driveVolumeLabel.Location = new System.Drawing.Point(173, 146);
            this.driveVolumeLabel.Name = "driveVolumeLabel";
            this.driveVolumeLabel.Size = new System.Drawing.Size(0, 20);
            this.driveVolumeLabel.TabIndex = 9;
            // 
            // driveTypeLabel
            // 
            this.driveTypeLabel.AutoSize = true;
            this.driveTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driveTypeLabel.Location = new System.Drawing.Point(173, 112);
            this.driveTypeLabel.Name = "driveTypeLabel";
            this.driveTypeLabel.Size = new System.Drawing.Size(0, 20);
            this.driveTypeLabel.TabIndex = 8;
            // 
            // driveFormatLabel
            // 
            this.driveFormatLabel.AutoSize = true;
            this.driveFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driveFormatLabel.Location = new System.Drawing.Point(173, 81);
            this.driveFormatLabel.Name = "driveFormatLabel";
            this.driveFormatLabel.Size = new System.Drawing.Size(0, 20);
            this.driveFormatLabel.TabIndex = 7;
            // 
            // freeSpaceLabel
            // 
            this.freeSpaceLabel.AutoSize = true;
            this.freeSpaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeSpaceLabel.Location = new System.Drawing.Point(173, 50);
            this.freeSpaceLabel.Name = "freeSpaceLabel";
            this.freeSpaceLabel.Size = new System.Drawing.Size(0, 20);
            this.freeSpaceLabel.TabIndex = 6;
            // 
            // totalSpaceLabel
            // 
            this.totalSpaceLabel.AutoSize = true;
            this.totalSpaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSpaceLabel.Location = new System.Drawing.Point(173, 17);
            this.totalSpaceLabel.Name = "totalSpaceLabel";
            this.totalSpaceLabel.Size = new System.Drawing.Size(0, 20);
            this.totalSpaceLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Volume label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Drive type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drive format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Free space";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total space";
            // 
            // dirInfoPanel
            // 
            this.dirInfoPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.dirInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dirInfoPanel.Controls.Add(this.dirList);
            this.dirInfoPanel.Controls.Add(this.dirListMenuStrip);
            this.dirInfoPanel.Location = new System.Drawing.Point(4, 5);
            this.dirInfoPanel.Name = "dirInfoPanel";
            this.dirInfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.dirInfoPanel.Size = new System.Drawing.Size(436, 287);
            this.dirInfoPanel.TabIndex = 1;
            this.dirInfoPanel.Text = "tabPage2";
            // 
            // dirList
            // 
            this.dirList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dirList.HideSelection = false;
            this.dirList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.dirList.Location = new System.Drawing.Point(-1, 30);
            this.dirList.Name = "dirList";
            this.dirList.Size = new System.Drawing.Size(437, 256);
            this.dirList.TabIndex = 0;
            this.dirList.UseCompatibleStateImageBehavior = false;
            this.dirList.View = System.Windows.Forms.View.Tile;
            this.dirList.ItemActivate += new System.EventHandler(this.viewListItemActive);
            this.dirList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dirList_MouseClick);
            // 
            // listViewItemContextMenu
            // 
            this.listViewItemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listItemToolStripMenuItem,
            this.listItem2ToolStripMenuItem,
            this.listItem3ToolStripMenuItem});
            this.listViewItemContextMenu.Name = "contextMenuStrip2";
            this.listViewItemContextMenu.Size = new System.Drawing.Size(123, 70);
            // 
            // listItemToolStripMenuItem
            // 
            this.listItemToolStripMenuItem.Name = "listItemToolStripMenuItem";
            this.listItemToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.listItemToolStripMenuItem.Text = "ListItem";
            // 
            // listItem2ToolStripMenuItem
            // 
            this.listItem2ToolStripMenuItem.Name = "listItem2ToolStripMenuItem";
            this.listItem2ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.listItem2ToolStripMenuItem.Text = "ListItem2";
            // 
            // listItem3ToolStripMenuItem
            // 
            this.listItem3ToolStripMenuItem.Name = "listItem3ToolStripMenuItem";
            this.listItem3ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.listItem3ToolStripMenuItem.Text = "ListItem3";
            // 
            // dirListMenuStrip
            // 
            this.dirListMenuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.dirListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem});
            this.dirListMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.dirListMenuStrip.Name = "dirListMenuStrip";
            this.dirListMenuStrip.Size = new System.Drawing.Size(428, 24);
            this.dirListMenuStrip.TabIndex = 1;
            this.dirListMenuStrip.Text = "menuStrip1";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.createNewToolStripMenuItem.Text = "Create new";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 367);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.browserString);
            this.Controls.Add(this.DirName);
            this.Controls.Add(this.drivesTree);
            this.MainMenuStrip = this.dirListMenuStrip;
            this.Name = "Form1";
            this.Text = "Яковенко Артем";
            this.tabControl1.ResumeLayout(false);
            this.driveInfoPanel.ResumeLayout(false);
            this.driveInfoPanel.PerformLayout();
            this.dirInfoPanel.ResumeLayout(false);
            this.dirInfoPanel.PerformLayout();
            this.listViewItemContextMenu.ResumeLayout(false);
            this.dirListMenuStrip.ResumeLayout(false);
            this.dirListMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView drivesTree;
        private System.Windows.Forms.Label DirName;
        private System.Windows.Forms.TextBox browserString;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage driveInfoPanel;
        private System.Windows.Forms.TabPage dirInfoPanel;
        private System.Windows.Forms.Label driveVolumeLabel;
        private System.Windows.Forms.Label driveTypeLabel;
        private System.Windows.Forms.Label driveFormatLabel;
        private System.Windows.Forms.Label freeSpaceLabel;
        private System.Windows.Forms.Label totalSpaceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView dirList;
        private System.Windows.Forms.ContextMenuStrip listViewItemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem listItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listItem2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listItem3ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip dirListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

