namespace SQLTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            libraryToolStripMenuItem = new ToolStripMenuItem();
            sourcesToolStripMenuItem = new ToolStripMenuItem();
            emissionsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { libraryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // libraryToolStripMenuItem
            // 
            libraryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sourcesToolStripMenuItem, emissionsToolStripMenuItem });
            libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            libraryToolStripMenuItem.Size = new Size(68, 24);
            libraryToolStripMenuItem.Text = "Library";
            // 
            // sourcesToolStripMenuItem
            // 
            sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
            sourcesToolStripMenuItem.Size = new Size(224, 26);
            sourcesToolStripMenuItem.Text = "Sources";
            sourcesToolStripMenuItem.Click += sourcesToolStripMenuItem_Click;
            // 
            // emissionsToolStripMenuItem
            // 
            emissionsToolStripMenuItem.Name = "emissionsToolStripMenuItem";
            emissionsToolStripMenuItem.Size = new Size(224, 26);
            emissionsToolStripMenuItem.Text = "Emissions";
            emissionsToolStripMenuItem.Click += emissionsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem libraryToolStripMenuItem;
        private ToolStripMenuItem sourcesToolStripMenuItem;
        private ToolStripMenuItem emissionsToolStripMenuItem;
    }
}