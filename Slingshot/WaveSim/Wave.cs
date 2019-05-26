using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveSim
{
    public partial class Wave : Form
    {
        public static Wave _instance;

        public Wave()
        {
            InitializeComponent();
            this.Size = new Size(840, 700);
        }

        public static Wave Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Wave();
                    return _instance;

                }
                return _instance;

            }
        }

        private void vScrollBar1_KeyDown(object sender, KeyEventArgs e)
        {
            int leftScrollValue = vScrollBar1.Value;
            textBox1.Text = leftScrollValue.ToString();
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int leftScrollValue = vScrollBar1.Value;
            textBox1.Text = leftScrollValue.ToString();
        }

        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            int rightScrollValue = vScrollBar2.Value;
            textBox2.Text = rightScrollValue.ToString();
        }

        private void Wave_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(40, 40, 360, 200));
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(410, 40, 360, 200));
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(0, 260, 9000, 400));
        }
    }
}
