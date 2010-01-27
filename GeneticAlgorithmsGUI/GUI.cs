using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using GeneticAlgorithms;
using GeneticAlgorithms.Example_Classes;
using ZedGraph;

namespace GeneticAlgorithmsGUI
{
    public partial class GUI : Form
    {
        private PointPairList avgFitnessList, avgLengthList, avgVariationList, maxFitnessList, minFitnessList;
        private LineItem avgFitnessCurve, avgLengthCurve, avgVariationCurve, maxFitnessCurve, minFitnessCurve;
        private GeneticSimulation<IntGene> GenSim = null;
        private MondlandungsSimulation MondSim = null;
        private IRecombinationProvider recombinationProvider = null;
        private ISelectionProvider selectionProvider = null;
        private Bitmap _backBuffer = null;
        private Graphics gBuffer = null;
        private Bitmap bmpWeltraum = null;
        private Bitmap bmpRaumschiffIntakt = null;
        private Bitmap bmpRaumschiffKaputt = null;
        private Bitmap bmpRaumschiff = null;
        private Bitmap bmpRaumschiffLeer = null;
        private Bitmap bmpTriebwerk = null;
        private Bitmap bmpRaumfahrer = null;
        private Bitmap bmpFahne = null;
        private bool simulationAbbrechen = false;

        private int letzteHoehe = 0;

        private int turn = 0;

        public GUI()
        {
            InitializeComponent();
            GraphPane p = zgc_Simulationsgraph.GraphPane;
            p.Title.Text = "Population";
            p.XAxis.Title.Text = "Runden";
            p.XAxis.Scale.Min = 1;
            p.XAxis.Scale.MaxAuto = true;
            p.YAxis.Title.Text = "Fitness";
            p.YAxis.Scale.Max = 1.0;
            p.YAxis.Scale.Min = 0.0;
            p.YAxisList.Add("Länge");
            p.YAxisList[1].IsVisible = false;
            p.YAxisList[1].Scale.MaxAuto = true;
            
            p.YAxisList[1].Scale.Min = 0;
            p.YAxisList.Add("Variation");
            p.YAxisList[2].IsVisible = false;

            this.avgFitnessList = new PointPairList();
            this.avgLengthList = new PointPairList();
            this.avgVariationList = new PointPairList();
            this.maxFitnessList = new PointPairList();
            this.minFitnessList = new PointPairList();

            this.avgFitnessCurve = p.AddCurve("Ø Fitness", avgFitnessList, Color.Green, SymbolType.None);
            this.avgLengthCurve = p.AddCurve("Ø Länge", avgLengthList, Color.Purple, SymbolType.None);
            this.avgVariationCurve = p.AddCurve("Ø Varation", avgVariationList, Color.Yellow, SymbolType.None);
            this.minFitnessCurve = p.AddCurve("min. Fitness", minFitnessList, Color.Red, SymbolType.None);
            this.maxFitnessCurve = p.AddCurve("max. Fitness", maxFitnessList, Color.Blue, SymbolType.None);

            avgLengthCurve.YAxisIndex = 1;

            avgFitnessCurve.IsVisible = true;
            avgVariationCurve.IsVisible = false;
            avgLengthCurve.IsVisible = false;
            minFitnessCurve.IsVisible = false;
            maxFitnessCurve.IsVisible = false;

            cmb_Rekombinator.SelectedIndex = 0;
            recombinationProvider = new AsymmetricCrossoverRecombinator();
            cmb_Selektor.SelectedIndex = 1;
            selectionProvider = new PieCakeSelector();

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream stream = null;
            
            stream = myAssembly.GetManifestResourceStream("GeneticAlgorithmsGUI.Weltraum.bmp");
            bmpWeltraum = new Bitmap(stream);
            stream = myAssembly.GetManifestResourceStream("GeneticAlgorithmsGUI.Raumschiff.gif");
            bmpRaumschiffIntakt = new Bitmap(stream);
            stream = myAssembly.GetManifestResourceStream("GeneticAlgorithmsGUI.Explosion.gif");
            bmpRaumschiffKaputt = new Bitmap(stream);
            stream = myAssembly.GetManifestResourceStream("GeneticAlgorithmsGUI.Triebwerk.gif");
            bmpTriebwerk = new Bitmap(stream);
            stream = myAssembly.GetManifestResourceStream("GeneticAlgorithmsGUI.Raumschiff_leer.gif");
            bmpRaumschiffLeer = new Bitmap(stream);
            stream = myAssembly.GetManifestResourceStream("GeneticAlgorithmsGUI.Raumfahrer.gif");
            bmpRaumfahrer = new Bitmap(stream);
            stream = myAssembly.GetManifestResourceStream("GeneticAlgorithmsGUI.Fahne.png");
            bmpFahne = new Bitmap(stream);

            _backBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            gBuffer = Graphics.FromImage(_backBuffer);
            gBuffer.Clear(Color.White);
        }

        private void pnl_Animation_Paint(object sender, PaintEventArgs e)
        {
            drawClearBackground();
        }

        private void drawClearBackground()
        {
            gBuffer.DrawImage(bmpWeltraum, 1, 1, 300, 650);
            pnl_Animation.CreateGraphics().DrawImageUnscaled(_backBuffer, 0, 0);
        }

        public void setzeRaumschiff(int hoehe, int schub)
        {
            gBuffer.DrawImage(bmpWeltraum, 0, 0, 300, 650);
            float yPosition = 550.0f/Convert.ToInt64(txt_Hoehe.Text);
            yPosition *= hoehe;
            yPosition = 550 - yPosition;
            int skalierterSchub = schub * 2;

            gBuffer.DrawImage(bmpTriebwerk, 150 - (skalierterSchub / 2), yPosition + 65, skalierterSchub, skalierterSchub);
            gBuffer.DrawImage(bmpRaumschiff, 100, Convert.ToInt32(yPosition), 100, 100);
            pnl_Animation.CreateGraphics().DrawImageUnscaled(_backBuffer, 0, 0);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Mondlandungs-Simulation mit genetischen Algorithmen.\n\n © 2010 Daniel Baulig, Sven Sperner, Jonas Heil, Christian Kleemann", "Über");
        }

        private void txt_Int_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToInt32((sender as TextBox).Text) < 0)
                    throw new FormatException();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Kein positiver Ganzzahlwert!");
                (sender as TextBox).SelectAll();
                e.Cancel = true;
            }
        }

        private void txt_Float_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToDouble((sender as TextBox).Text) < 0)
                    throw new FormatException();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Kein positiver Gleitkommawert!");
                (sender as TextBox).SelectAll();
                e.Cancel = true;
            }
        }

        private void chk_AVGFitness_CheckedChanged(object sender, EventArgs e)
        {
            avgFitnessCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[0].IsVisible = chk_AVGFitness.Checked || chk_maxFitness.Checked || chk_minFitness.Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        private void chk_Laenge_CheckedChanged(object sender, EventArgs e)
        {
            avgLengthCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[1].IsVisible = avgLengthCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        private void chk_Variation_CheckedChanged(object sender, EventArgs e)
        {
            avgVariationCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[2].IsVisible = avgVariationCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        private void chk_minFitness_CheckedChanged(object sender, EventArgs e)
        {
            minFitnessCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[0].IsVisible = chk_minFitness.Checked || chk_maxFitness.Checked || chk_minFitness.Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        private void chk_maxFitness_CheckedChanged(object sender, EventArgs e)
        {
            maxFitnessCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[0].IsVisible = chk_maxFitness.Checked || chk_maxFitness.Checked || chk_minFitness.Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        private void btn_Zuruecksetzten_Click(object sender, EventArgs e)
        {
            avgLengthList.Clear();
            avgVariationList.Clear();
            avgFitnessList.Clear();
            maxFitnessList.Clear();
            minFitnessList.Clear();
            GenSim = null;
            MondSim = null;
            turn = 0;
            cmb_Selektor.Enabled = true;
            cmb_Rekombinator.Enabled = true;
            txt_Chromosomlaenge.Enabled = true;
            txt_Gewicht.Enabled = true;
            txt_Hoehe.Enabled = true;
            txt_Treibstoff.Enabled = true;
            txt_Mutationsrate.Enabled = true;
            txt_Verlustrate.Enabled = true;
            txt_Duplikationsrate.Enabled = true;
            dgv_Population.Rows.Clear();
            btn_Abspielen.Enabled = false;
            //zgc_Simulationsgraph.GraphPane.CurveList.Clear();
            zgc_Simulationsgraph.GraphPane.GraphObjList.Clear();
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
            drawClearBackground();
            GraphPane p = zgc_Simulationsgraph.GraphPane;
            p.YAxisList[1].Scale.Max = 10;
            p.YAxisList[1].Scale.MaxAuto = true;
        }

        private void OnSimulationTurn(object sender, EventArgs e)
        {
            turn ++;
            if (simulationAbbrechen)
            {
                GenSim.AbortSimulation();
                simulationAbbrechen = false;
            }
            this.avgFitnessList.Add(turn, GenSim.AverageFitness);
            this.avgLengthList.Add(turn, GenSim.AverageChromosomeLength);
            if (zgc_Simulationsgraph.GraphPane.YAxisList[1].Scale.Max < GenSim.AverageChromosomeLength)
                zgc_Simulationsgraph.GraphPane.YAxisList[1].Scale.Max = GenSim.AverageChromosomeLength + 1;
            this.maxFitnessList.Add(turn, GenSim.MostSuccessfullIndividual.Fitness);
            this.minFitnessList.Add(turn, GenSim.LeasSuccessfullIndividual.Fitness);
            if (turn % 10 == 0 && chk_Live.Checked)
            {
                zgc_Simulationsgraph.AxisChange();
                zgc_Simulationsgraph.Invalidate();
            }
            Application.DoEvents();
        }

        private void btn_Simuliere_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (GenSim == null)
            {
                btn_Abspielen.Enabled = true;
                txt_Chromosomlaenge.Enabled = false;
                cmb_Rekombinator.Enabled = false;
                cmb_Selektor.Enabled = false;
                txt_Gewicht.Enabled = false;
                txt_Hoehe.Enabled = false;
                txt_Treibstoff.Enabled = false;
                txt_Mutationsrate.Enabled = false;
                txt_Verlustrate.Enabled = false;
                txt_Duplikationsrate.Enabled = false;
                IntGene.MaxValue = Convert.ToInt32(txt_Treibstoff.Text);
                MondSim = new MondlandungsSimulation(Convert.ToInt32(txt_Hoehe.Text), Convert.ToInt32(txt_Treibstoff.Text), Convert.ToInt32(txt_Gewicht.Text), tsmi_RaumfahrerGewicht.Checked);
                GenSim = new GeneticSimulation<IntGene>(100, Convert.ToInt32(txt_Chromosomlaenge.Text), MondSim, recombinationProvider, selectionProvider);
                GenSim.SimulationTurn += OnSimulationTurn;
                GenSim.GeneMutationRate = Convert.ToDouble(txt_Mutationsrate.Text);
                GenSim.GeneDuplicationRate = Convert.ToDouble(txt_Duplikationsrate.Text);
                GenSim.GeneDropRate = Convert.ToDouble(txt_Verlustrate.Text);
            }
            if (sender == btn_AutoSim)
            {
                btn_AutoSim.Enabled = false;
                btn_Simuliere.Enabled = false;
                btn_Zuruecksetzen.Enabled = false;
                btn_SimAbbrechen.Focus();
                float fitnessGrenze = Convert.ToSingle(txt_Fitness.Text);
                float startFitness = GenSim.AverageFitness;
                while (fitnessGrenze + startFitness > GenSim.AverageFitness && !simulationAbbrechen)
                {
                    Application.DoEvents();
                    GenSim.RunSimulation();
                }
                simulationAbbrechen = false;
                btn_Simuliere.Enabled = true;
                btn_Zuruecksetzen.Enabled = true;
                btn_AutoSim.Enabled = true;
            }
            else
                GenSim.RunSimulation(Convert.ToInt32(txt_Rundenazahl.Text));

            dgv_Population.Rows.Clear();

            dgv_Population.Rows.Add(GenSim.PoppulationSize);
            for (int i = 0; i < GenSim.PoppulationSize; i++)
            {
                dgv_Population.Rows[i].Cells[0].Value = GenSim[i].GeneCount.ToString();
                dgv_Population.Rows[i].Cells[1].Value = GenSim[i].ToString();
                dgv_Population.Rows[i].Cells[2].Value = GenSim[i].Fitness.ToString();
                dgv_Population.Rows[i].Tag = GenSim[i];
            }

            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
            Cursor = Cursors.Default;
        }

        private void cmb_Selektor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0: // Alpha
                    selectionProvider = new AlphaSelector();
                    break;
                case 1: // Pie Cake
                    selectionProvider = new PieCakeSelector();
                    break;
                case 2: // Random
                    selectionProvider = new RandomSelector();
                    break;
                default:
                    selectionProvider = new PieCakeSelector();
                    break;
            }
        }

        private void cmb_Rekombinator_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0: // Crossover
                    recombinationProvider = new AsymmetricCrossoverRecombinator();
                    break;
                case 1: // Zip
                    recombinationProvider = new AsymmetricZipRecombinator();
                    break;
                default:
                    recombinationProvider = new AsymmetricCrossoverRecombinator();
                    break;
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            /*
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Left = 0;
            Top = 0;
             */
        }

        private void setzeRaumfahrer(int x)
        {
            setzeRaumschiff(0, 0);
            gBuffer.DrawImage(bmpRaumfahrer, x, 590, 25, 50);
            pnl_Animation.CreateGraphics().DrawImageUnscaled(_backBuffer, 0, 0);
        }

        private void OnMondlandungsSimulationTurn(object sender, EventArgs e)
        {
            MondlandungsSimulationEventArgs mondlandungsArgs = e as MondlandungsSimulationEventArgs;
            //this.Text = Convert.ToString(mondlandungsArgs.Raumschiff.Geschwindigkeit);
            lbl_AktGeschwindigkeit.Text = Convert.ToString(mondlandungsArgs.Raumschiff.Geschwindigkeit);
            lbl_AktHoehe.Text = Convert.ToString(mondlandungsArgs.Raumschiff.Hoehe);
            lbl_AktSchub.Text = Convert.ToString(mondlandungsArgs.Schub);
            lbl_AktTank.Text = Convert.ToString(mondlandungsArgs.Raumschiff.Treibstoff);
            Application.DoEvents();
            float floatHoehe = letzteHoehe;
            if (mondlandungsArgs.Raumschiff.Geschwindigkeit  > 0)
                while (floatHoehe < mondlandungsArgs.Raumschiff.Hoehe)
                {
                    floatHoehe += mondlandungsArgs.Raumschiff.Geschwindigkeit / 10.0f;
                    System.Threading.Thread.Sleep(10);
                    setzeRaumschiff(Convert.ToInt32(floatHoehe), mondlandungsArgs.Schub);
                }
            else
                while (floatHoehe > mondlandungsArgs.Raumschiff.Hoehe)
                {
                    floatHoehe += mondlandungsArgs.Raumschiff.Geschwindigkeit / 10.0f;
                    System.Threading.Thread.Sleep(10);
                    if (floatHoehe <= 0)
                    {
                        setzeRaumschiff(0, mondlandungsArgs.Schub);
                    }
                    else
                        setzeRaumschiff(Convert.ToInt32(floatHoehe), mondlandungsArgs.Schub);
                }
            letzteHoehe = mondlandungsArgs.Raumschiff.Hoehe;

            if (letzteHoehe <= 0)
                if ((mondlandungsArgs.Raumschiff.Geschwindigkeit + 10) < 0)
                {
                    bmpRaumschiff = bmpRaumschiffKaputt;
                    setzeRaumschiff(0, 0);
                }
                else
                {
                    setzeRaumschiff(0, 0);
                    System.Threading.Thread.Sleep(500);
                    bmpRaumschiff = bmpRaumschiffLeer;
                    setzeRaumschiff(0, 0);
                    System.Threading.Thread.Sleep(500);
                    setzeRaumfahrer(100);
                    System.Threading.Thread.Sleep(100);
                    setzeRaumfahrer(110);
                    System.Threading.Thread.Sleep(100);
                    setzeRaumfahrer(120);
                    System.Threading.Thread.Sleep(100);
                    setzeRaumfahrer(130);
                    System.Threading.Thread.Sleep(100);
                    setzeRaumfahrer(140);
                    System.Threading.Thread.Sleep(100);
                    setzeRaumfahrer(150);
                    System.Threading.Thread.Sleep(100);
                    setzeRaumfahrer(160);
                    System.Threading.Thread.Sleep(100);
                    setzeRaumfahrer(170);
                    System.Threading.Thread.Sleep(100);
                    gBuffer.DrawImage(bmpFahne, 200, 560, 37, 75);
                    pnl_Animation.CreateGraphics().DrawImageUnscaled(_backBuffer, 0, 0);

                }
            
            //setzeRaumschiff(letzteHoehe, mondlandungsArgs.Schub);
            //System.Threading.Thread.Sleep(1);
        }

        private void btn_Abspielen_Click(object sender, EventArgs e)
        {
            if (dgv_Population.SelectedRows.Count > 0)
            {
                btn_Abspielen.Enabled = false;
                Cursor = Cursors.WaitCursor;
                bmpRaumschiff = bmpRaumschiffIntakt;
                letzteHoehe = Convert.ToInt32(txt_Hoehe.Text);
                MondSim.SimulationTurn += OnMondlandungsSimulationTurn;
                (dgv_Population.SelectedRows[0].Tag as Chromosome<IntGene>).computeFitness(MondSim);
                MondSim.SimulationTurn -= OnMondlandungsSimulationTurn;
                Cursor = Cursors.Default;
                btn_Abspielen.Enabled = true;
            }
        }

        private void btn_SimAbbrechen_Click(object sender, EventArgs e)
        {
            simulationAbbrechen = true;
        }

        private void gewichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
        }
    }

}

 