﻿namespace ParticleCollision
{
    partial class Particle
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
            this.SuspendLayout();
            // 
            // Particle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Particle";
            this.Text = "Particle Collision";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Particle_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Particle_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Particle_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Particle_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

