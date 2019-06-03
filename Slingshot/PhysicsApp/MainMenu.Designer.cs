namespace PhysicsApp
{
    partial class MainMenu
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.slingshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tessellateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.particleCollisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slingshotToolStripMenuItem,
            this.waveToolStripMenuItem,
            this.tessellateToolStripMenuItem,
            this.particleCollisionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 29);
            this.toolStripMenuItem1.Text = "Physics Apps";
            // 
            // slingshotToolStripMenuItem
            // 
            this.slingshotToolStripMenuItem.Name = "slingshotToolStripMenuItem";
            this.slingshotToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.slingshotToolStripMenuItem.Text = "Slingshot";
            this.slingshotToolStripMenuItem.Click += new System.EventHandler(this.slingshotToolStripMenuItem_Click);
            // 
            // waveToolStripMenuItem
            // 
            this.waveToolStripMenuItem.Name = "waveToolStripMenuItem";
            this.waveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.waveToolStripMenuItem.Text = "Wave Merge";
            this.waveToolStripMenuItem.Click += new System.EventHandler(this.waveToolStripMenuItem_Click);
            // 
            // tessellateToolStripMenuItem
            // 
            this.tessellateToolStripMenuItem.Name = "tessellateToolStripMenuItem";
            this.tessellateToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.tessellateToolStripMenuItem.Text = "Tessellate";
            this.tessellateToolStripMenuItem.Click += new System.EventHandler(this.tessellateToolStripMenuItem_Click);
            // 
            // particleCollisionToolStripMenuItem
            // 
            this.particleCollisionToolStripMenuItem.Name = "particleCollisionToolStripMenuItem";
            this.particleCollisionToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.particleCollisionToolStripMenuItem.Text = "Particle Collision";
            this.particleCollisionToolStripMenuItem.Click += new System.EventHandler(this.particleCollisionToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "PhysicsAppMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem slingshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tessellateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem particleCollisionToolStripMenuItem;
    }
}

