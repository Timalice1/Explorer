﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Lab2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            drivesTree.Nodes.Clear();

            //drivesTree.BeforeSelect += drivesTree_BeforeSelect;
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
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0) {
                        for (int i = 0; i < dirs.Length; i++) {
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
                MessageBox.Show(ex.Message);
            }
        }


        //void drivesTree_BeforeSelect(object sender, TreeViewCancelEventArgs e) {
        //    e.Node.Nodes.Clear();
        //    string[] dirs;
        //    try {
        //        if (Directory.Exists(e.Node.FullPath)) {
        //            dirs = Directory.GetDirectories(e.Node.FullPath);
        //            if (dirs.Length != 0) {
        //                for (int i = 0; i < dirs.Length; i++) {
        //                    TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
        //                    FillTreeNode(dirNode, dirs[i]);
        //                    e.Node.Nodes.Add(dirNode);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex) {
        //    }
        //}

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
    }
}