namespace practice
{
    partial class Form3
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
            this.rEGESTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dISPLAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGESTRATIONToolStripMenuItem,
            this.dISPLAYToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGESTRATIONToolStripMenuItem
            // 
            this.rEGESTRATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.displayToolStripMenuItem2});
            this.rEGESTRATIONToolStripMenuItem.Name = "rEGESTRATIONToolStripMenuItem";
            this.rEGESTRATIONToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.rEGESTRATIONToolStripMenuItem.Text = "Registration";
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStudentsToolStripMenuItem.Text = "add students";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem2
            // 
            this.displayToolStripMenuItem2.Name = "displayToolStripMenuItem2";
            this.displayToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem2.Text = "display";
            this.displayToolStripMenuItem2.Click += new System.EventHandler(this.displayToolStripMenuItem2_Click);
            // 
            // dISPLAYToolStripMenuItem
            // 
            this.dISPLAYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllProductToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.dISPLAYToolStripMenuItem.Name = "dISPLAYToolStripMenuItem";
            this.dISPLAYToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dISPLAYToolStripMenuItem.Text = "View";
            // 
            // displayAllProductToolStripMenuItem
            // 
            this.displayAllProductToolStripMenuItem.Name = "displayAllProductToolStripMenuItem";
            this.displayAllProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayAllProductToolStripMenuItem.Text = "display all product";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "search";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGESTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dISPLAYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}