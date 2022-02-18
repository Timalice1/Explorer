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
            this.drivesTree = new System.Windows.Forms.TreeView();
            this.DirName = new System.Windows.Forms.Label();
            this.browserString = new System.Windows.Forms.TextBox();
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
            this.DirName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirName.Location = new System.Drawing.Point(197, 46);
            this.DirName.Name = "DirName";
            this.DirName.Size = new System.Drawing.Size(157, 25);
            this.DirName.TabIndex = 1;
            this.DirName.Text = "Directory name";
            // 
            // browserString
            // 
            this.browserString.Location = new System.Drawing.Point(197, 12);
            this.browserString.Name = "browserString";
            this.browserString.Size = new System.Drawing.Size(442, 20);
            this.browserString.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 367);
            this.Controls.Add(this.browserString);
            this.Controls.Add(this.DirName);
            this.Controls.Add(this.drivesTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView drivesTree;
        private System.Windows.Forms.Label DirName;
        private System.Windows.Forms.TextBox browserString;
    }
}

