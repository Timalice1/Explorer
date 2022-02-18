using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Lab2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            drivesTree.Nodes.Clear();

            drivesTree.BeforeExpand += drivesTree_BeforeExpand;

            //Fill tree with drives
            FillDriveNodes();
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

        void driverTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            DirName.Text = e.Node.Text;
            browserString.Text = e.Node.FullPath;//Set full path of choosed node for browser string
        }
    }
}