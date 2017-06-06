namespace Find_University_and_Course
{
    partial class Administrator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUniversityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUniversityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUniversityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUniversityToolStripMenuItem,
            this.viewUniversityToolStripMenuItem,
            this.updateUniversityToolStripMenuItem,
            this.addCourseToolStripMenuItem,
            this.viewCourseToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUniversityToolStripMenuItem
            // 
            this.addUniversityToolStripMenuItem.Name = "addUniversityToolStripMenuItem";
            this.addUniversityToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.addUniversityToolStripMenuItem.Text = "Add University";
            this.addUniversityToolStripMenuItem.Click += new System.EventHandler(this.addUniversityToolStripMenuItem_Click);
            // 
            // viewUniversityToolStripMenuItem
            // 
            this.viewUniversityToolStripMenuItem.Name = "viewUniversityToolStripMenuItem";
            this.viewUniversityToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.viewUniversityToolStripMenuItem.Text = "View University";
            this.viewUniversityToolStripMenuItem.Click += new System.EventHandler(this.viewUniversityToolStripMenuItem_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // viewCourseToolStripMenuItem
            // 
            this.viewCourseToolStripMenuItem.Name = "viewCourseToolStripMenuItem";
            this.viewCourseToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.viewCourseToolStripMenuItem.Text = "View Course";
            this.viewCourseToolStripMenuItem.Click += new System.EventHandler(this.viewCourseToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // updateUniversityToolStripMenuItem
            // 
            this.updateUniversityToolStripMenuItem.Name = "updateUniversityToolStripMenuItem";
            this.updateUniversityToolStripMenuItem.Size = new System.Drawing.Size(160, 25);
            this.updateUniversityToolStripMenuItem.Text = "Update University";
            this.updateUniversityToolStripMenuItem.Click += new System.EventHandler(this.updateUniversityToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 615);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUniversityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUniversityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUniversityToolStripMenuItem;
    }
}