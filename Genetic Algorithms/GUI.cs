using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            Graphics g = pe.Graphics;

            Pen bp = new Pen(Color.Black, 2);
            Pen sp = new Pen(Color.Red, 2);

            Point pt1 = new Point();
            Point pt2 = new Point();

            double ballX;
            double ballY;

            double ballRotX;
            double ballRotY;

            // Draw UFO
            g.DrawImage(
    
//            g.DrawLine(bp, pt1, pt2);

        }

    }

}
