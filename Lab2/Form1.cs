using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Lab2 {
    public partial class Form1 : Form {
        List<string> drives = new List<string>();
        private string path;
        private string prevPath;

        public Form1() {
            InitializeComponent();
            drivesTree.Nodes.Clear();

            drivesTree.BeforeExpand += drivesTree_BeforeExpand;

            //Fill tree with drives
            FillDriveNodes();


            //Convert Drive info array to list
            foreach (var drive in DriveInfo.GetDrives()) {
                drives.Add(drive.Name);
            }

            //Hide all tabs from start
            tabControl1.Visible = false;

        }


        void drivesTree_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            e.Node.Nodes.Clear();
            string[] dirs;
            DirectoryInfo info = null;
            try {
                if (Directory.Exists(e.Node.FullPath)) {
                    dirs = Directory.GetDirectories(e.Node.FullPath);//Get all directories from current path
                    if (dirs.Length != 0) {
                        for (int i = 0; i < dirs.Length; i++) {
                            //If directory is hidden, skip her
                            info = new DirectoryInfo(dirs[i]);
                            if (info.Attributes.HasFlag(FileAttributes.Hidden))
                                continue;
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) {
            }
        }

        //Get all drives from pc
        private void FillDriveNodes() {
            try {
                foreach (DriveInfo drive in DriveInfo.GetDrives()) {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    drivesTree.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) {
            }
        }

        //Get child nodes for current node
        private void FillTreeNode(TreeNode driveNode, string path) {
            try {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs) {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) {
            }
        }

        //Click handler for nodes
        void driverTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            
            //If selected node is Drive, set path == Drive.Name
            if (drives.Contains(e.Node.Text)) {
                GetDriveInfo(e.Node.Text);
            }
            //Else set full path of directory
            else {

                GetDirInfo(e.Node.FullPath);
            }

            browserString.Text = e.Node.FullPath;//Set full path of selected node for browser string
        }

        private void GetDirInfo(String _path) {
            tabControl1.Visible = true;
            tabControl1.SelectTab(dirInfoPanel);
            DirName.Text = _path.Remove(0, _path.LastIndexOf("\\") + 1);


            prevPath = path;
            path = _path;


            dirList.Items.Clear();
            DirectoryInfo directoryInfo = null;
            string[] files = Directory.GetFileSystemEntries(_path);
            foreach (string file in files) {

                directoryInfo = new DirectoryInfo(file);
                if (directoryInfo.Attributes.HasFlag(FileAttributes.Hidden)) {
                    continue;
                }
                dirList.Items.Add(directoryInfo.Name);
            }
        }

        private void GetDriveInfo(String name) {
            tabControl1.Visible = true;
            DirName.Text = name;

            foreach (DriveInfo drive in DriveInfo.GetDrives()) {
                if (drive.Name == name) {
                    path = drive.Name;
                    tabControl1.SelectTab(driveInfoPanel);
                    totalSpaceLabel.Text = (drive.TotalSize / (1048576 * 1024)).ToString() + " GB";
                    freeSpaceLabel.Text = (drive.AvailableFreeSpace / (1048576 * 1024)).ToString() + " GB";
                    driveFormatLabel.Text = drive.DriveFormat;
                    driveTypeLabel.Text = drive.DriveType.ToString();
                    driveVolumeLabel.Text = drive.VolumeLabel;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e) {
            try {
            
                prevPath = path;
                path = browserString.Text;
                if (drives.Contains(path)) {
                    GetDriveInfo(path);
                }
                else {
                    GetDirInfo(path);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        void browserString_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                searchButton_Click(sender, e);
            }
        }

        void viewListItemActive(object sender, EventArgs e) {
            ListView list = (ListView)sender;
            var item = list.FocusedItem;

            prevPath = path;
            

            DirectoryInfo directoryInfo = new DirectoryInfo(path + "\\" + item.Text);
            if (directoryInfo.Attributes.HasFlag(FileAttributes.Directory)){
                GetDirInfo(path + "\\" + item.Text);
                browserString.Text = path;
            }
            else {
                try {
                    Process process = Process.Start(path + "\\" + item.Text);
                }
                catch (Exception ex) { }
            }
        }

        //Add context menu for list view items
        void dirList_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var focusedItem = dirList.FocusedItem;
                bool contains = focusedItem.Bounds.Contains(e.Location);
                if (focusedItem != null && contains) {
                    listViewItemContextMenu.Show(Cursor.Position);
                }
            }
            
        }

        //Create new folder from list view menu strip
        private void folderToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Dialog dialog = new Dialog();
                DialogResult result = dialog.ShowDialog();
                if (Directory.Exists($"{path}\\{dialog.name}")) {
                    throw new Exception("This folder already exists");
                }
                Directory.CreateDirectory($"{path}\\{dialog.name}");
                GetDirInfo(path);
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //Create new file from list view menu strip
        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Dialog dialog = new Dialog();
                DialogResult result = dialog.ShowDialog();
                if (File.Exists($"{path}\\{dialog.name}")) {
                    throw new Exception("This file already exists");
                }
                File.Create($"{path}\\{dialog.name}");
                GetDirInfo(path);
            }
            catch(System.Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}