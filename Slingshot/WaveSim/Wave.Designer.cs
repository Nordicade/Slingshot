namespace WaveSim
{
    partial class Wave
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(9, 60);
            this.vScrollBar1.Maximum = 59;
            this.vScrollBar1.Minimum = 1;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 148);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Value = 25;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            this.vScrollBar1.Enter += new System.EventHandler(this.vScrollBar1_Enter);
            this.vScrollBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vScrollBar1_KeyDown);
            this.vScrollBar1.MouseHover += new System.EventHandler(this.vScrollBar1_MouseHover);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(1171, 60);
            this.vScrollBar2.Maximum = 59;
            this.vScrollBar2.Minimum = 1;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(30, 148);
            this.vScrollBar2.TabIndex = 1;
            this.vScrollBar2.Value = 25;
            this.vScrollBar2.ValueChanged += new System.EventHandler(this.vScrollBar2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Merge";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(9, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Amplitude:25";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1001, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Frequency:.55";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(215, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 26);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Frequency:.55";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(795, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 26);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Amplitude:25";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(9, 228);
            this.vScrollBar3.Maximum = 109;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(30, 148);
            this.vScrollBar3.TabIndex = 7;
            this.vScrollBar3.Value = 55;
            this.vScrollBar3.ValueChanged += new System.EventHandler(this.vScrollBar3_ValueChanged);
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(1171, 228);
            this.vScrollBar4.Maximum = 109;
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(30, 148);
            this.vScrollBar4.TabIndex = 8;
            this.vScrollBar4.Value = 55;
            this.vScrollBar4.ValueChanged += new System.EventHandler(this.vScrollBar4_ValueChanged);
            // 
            // Wave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 758);
            this.Controls.Add(this.vScrollBar4);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Wave";
            this.Text = "Wave";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Wave_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar4;
    }
}

