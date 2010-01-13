using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace GeneticAlgorithmsGUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            GraphPane p = zgc_Simulationsgraph.GraphPane;
            p.Title.Text = "Population";
            p.XAxis.Title.Text = "Runden";
            p.YAxis.Title.Text = "Durchschnittliche Fitness";
            p.Y2Axis.Title.Text = "Bla";
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            /*Graphics g = pe.Graphics;

            Pen bp = new Pen(Color.Black, 2);
            Pen sp = new Pen(Color.Red, 2);

            Point pt1 = new Point();
            Point pt2 = new Point();

            double ballX;
            double ballY;

            double ballRotX;
            double ballRotY;

            // Draw UFO
       //     g.DrawImage(
    
//            g.DrawLine(bp, pt1, pt2);*/

        }

        private void lbl_Chromosome_Click(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }

}
