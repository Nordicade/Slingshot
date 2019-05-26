using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveSim;

namespace PhysicsApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            this.Height = 200;
            this.Width = 200;
            this.MinimumSize = new System.Drawing.Size(1250,1000);
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
    }
}
