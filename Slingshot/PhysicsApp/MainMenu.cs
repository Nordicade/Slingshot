﻿using ParticleCollision;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tessellate;
using WaveSim;

namespace PhysicsApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            // this.Size = new Size(900, 1100);
            this.Location = new Point(5,5);
            this.MinimumSize = new System.Drawing.Size(1300,1600);
            InitializeComponent();
        }

        private void showForm(Form _form)
        {
            _form.MdiParent = this;
            _form.Show();
            _form.Activate();
        }

        private void slingshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(SlingshotAnimation.Form1A.Instance);  
        }

        private void waveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(Wave.Instance);
        }

        private void tessellateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(Canvas.Instance);
        }

        private void particleCollisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(Particle.Instance);
        }
    }
}
