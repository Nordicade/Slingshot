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
            DrawWaveBoxLeft();
            DrawWaveBoxRight();
            DrawWaveBoxMid();
        }

        private void DrawWaveBoxMid()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(9, 50, 200, 100));
        }

        private void DrawWaveBoxRight()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(205, 105, 400, 500));
        }

        private void DrawWaveBoxLeft()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(Brushes.Black), new Rectangle(9,50,200,100));
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
    }
}
