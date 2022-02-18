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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.drivesTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // drivesTree
            // 
            this.drivesTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drivesTree.Location = new System.Drawing.Point(14, 12);
            this.drivesTree.Name = "drivesTree";
            treeNode1.BackColor = System.Drawing.Color.Red;
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Узел0";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Узел1";
            this.drivesTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.drivesTree.Size = new System.Drawing.Size(177, 343);
            this.drivesTree.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 367);
            this.Controls.Add(this.drivesTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView drivesTree;
    }
}

