﻿namespace SlingshotAnimation
{
    partial class Form1A
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
            // Form1A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 767);
            this.Name = "Form1A";
            this.Text = "Slingshot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1A_FormClosed);
            this.ClientSizeChanged += new System.EventHandler(this.Form1A_ClientSizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1A_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1A_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

