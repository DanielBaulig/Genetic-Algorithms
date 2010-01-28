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
        private bool closingApplication = false;

        private int letzteHoehe = 0;

        private int turn = 0;

        /// <summary>
        /// Konstruktor - Initialisierung der Bedienoberfläche
        /// </summary>
        public GUI()
        {
            InitializeComponent();
            //Initialisireung des ZedGraph
            GraphPane graphPane = zgc_Simulationsgraph.GraphPane;
            graphPane.Title.Text = "Population";
            graphPane.XAxis.Title.Text = "Runden";
            graphPane.XAxis.Scale.Min = 1;
            graphPane.XAxis.Scale.MaxAuto = true;
            graphPane.YAxis.Title.Text = "Fitness";
            graphPane.YAxis.Scale.Max = 1.0;
            graphPane.YAxis.Scale.Min = 0.0;
            graphPane.YAxisList.Add("Länge");
            graphPane.YAxisList[1].IsVisible = false;
            graphPane.YAxisList[1].Scale.MaxAuto = true;
            graphPane.YAxisList[1].Scale.Min = 0;

            //Initialisireung der Graphen
            this.avgFitnessList = new PointPairList();
            this.avgLengthList = new PointPairList();
            this.avgVariationList = new PointPairList();
            this.maxFitnessList = new PointPairList();
            this.minFitnessList = new PointPairList();
            this.avgFitnessCurve = graphPane.AddCurve("Ø Fitness", avgFitnessList, Color.Green, SymbolType.None);
            this.avgLengthCurve = graphPane.AddCurve("Ø Länge", avgLengthList, Color.Purple, SymbolType.None);
            this.minFitnessCurve = graphPane.AddCurve("min. Fitness", minFitnessList, Color.Red, SymbolType.None);
            this.maxFitnessCurve = graphPane.AddCurve("max. Fitness", maxFitnessList, Color.Blue, SymbolType.None);
            avgLengthCurve.YAxisIndex = 1;
            avgFitnessCurve.IsVisible = true;
            avgLengthCurve.IsVisible = false;
            minFitnessCurve.IsVisible = false;
            maxFitnessCurve.IsVisible = false;

            //Initialisireung der ComboBoxen
            cmb_Rekombinator.SelectedIndex = 0;
            recombinationProvider = new AsymmetricCrossoverRecombinator();
            cmb_Selektor.SelectedIndex = 1;
            selectionProvider = new PieCakeSelector();

            //Assembly erzeugen
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream stream = null;
            
            // Bilder aus den Ressourcen der Assembly holen
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

            //Initialisierung des DoubleBuffer
            _backBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            gBuffer = Graphics.FromImage(_backBuffer);
            gBuffer.Clear(Color.White);
        }


        /// <summary>
        /// Paint Ereignis
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void pnl_Animation_Paint(object sender, PaintEventArgs e)
        {
            drawClearBackground();
        }


        /// <summary>
        /// leere Weltraum-/Mondlandschaft zeichnen
        /// </summary>
        private void drawClearBackground()
        {
            gBuffer.DrawImage(bmpWeltraum, 1, 1, 300, 650);
            pnl_Animation.CreateGraphics().DrawImageUnscaled(_backBuffer, 0, 0);
        }

        /// <summary>
        /// Raumschiffbild auf dem Hintergrund in bestimmter Höhe platzieren
        /// </summary>
        /// <param name="hoehe">Höhe des Raumschiffs</param>
        /// <param name="schub">gegebener Schub</param>
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

        /// <summary>
        /// Beenden der Anwendung
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// "Über"-Dialogfenster anzeigen
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Mondlandungs-Simulation mit genetischen Algorithmen\n\nVersion 1.0\n\nEntwickelt von Daniel Baulig, Jonas Heil, Christian Kleemann, Sven Sperner", "Über");
        }


        /// <summary>
        /// Validierung eines eingegebenen Ganzzahl-Parameters
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
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

        /// <summary>
        /// Validierung eines eingegebenen Fliesskomma-Parameters
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
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

        /// <summary>
        /// Durchschnittliche Fitness der Population ein-/ausblenden
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void chk_AVGFitness_CheckedChanged(object sender, EventArgs e)
        {
            avgFitnessCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[0].IsVisible = chk_AVGFitness.Checked || chk_maxFitness.Checked || chk_minFitness.Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        /// <summary>
        /// Durchschnittliche Chromosomlänge der Population ein-/ausblenden
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void chk_Laenge_CheckedChanged(object sender, EventArgs e)
        {
            avgLengthCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[1].IsVisible = avgLengthCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        /// <summary>
        /// Minimale Fitness der Population ein-/ausblenden
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void chk_minFitness_CheckedChanged(object sender, EventArgs e)
        {
            minFitnessCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[0].IsVisible = chk_AVGFitness.Checked || chk_maxFitness.Checked || chk_minFitness.Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        /// <summary>
        /// Maximale Fitness der Population ein-/ausblenden
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void chk_maxFitness_CheckedChanged(object sender, EventArgs e)
        {
            maxFitnessCurve.IsVisible = (sender as CheckBox).Checked;
            zgc_Simulationsgraph.GraphPane.YAxisList[0].IsVisible = chk_AVGFitness.Checked || chk_maxFitness.Checked || chk_minFitness.Checked;
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
        }

        /// <summary>
        /// Simulationsergebnisse zurücksetzen
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
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
            lbl_AktGeschwindigkeit.Text = "0";
            lbl_AktHoehe.Text = "0";
            lbl_AktSchub.Text = "0";
            lbl_AktTank.Text = "0";
            chk_AVGFitness.Checked = true;
            chk_maxFitness.Checked = false;
            chk_minFitness.Checked = false;
            chk_Laenge.Checked = false;
            chk_Live.Checked = false;
            zgc_Simulationsgraph.GraphPane.GraphObjList.Clear();
            zgc_Simulationsgraph.AxisChange();
            zgc_Simulationsgraph.Invalidate();
            drawClearBackground();
            GraphPane p = zgc_Simulationsgraph.GraphPane;
            zgc_Simulationsgraph.ZoomOutAll(p);
            p.YAxisList[1].Scale.Max = 10;
            p.YAxisList[1].Scale.MaxAuto = true;

        }

        /// <summary>
        /// Simulationsrunde durchlaufen
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
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

        /// <summary>
        /// Simulation starten
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void btn_Simuliere_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btn_Simuliere.Enabled = false;
            btn_Zuruecksetzen.Enabled = false;
            btn_AutoSim.Enabled = false;
            btn_SimAbbrechen.Focus();
            //erster Durchlauf der Simulation
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
            //automatisierte Simulation bis Erreichen der Delta-Fitness
            if (sender == btn_AutoSim)
            {
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
            //einfache Simulation mit angegebener Rundenzahl
            else
                GenSim.RunSimulation(Convert.ToInt32(txt_Rundenazahl.Text));

            if (!closingApplication)
            {
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
                btn_Simuliere.Enabled = true;
                btn_Zuruecksetzen.Enabled = true;
                btn_AutoSim.Enabled = true;
            }
        }

        /// <summary>
        /// Selektor ausgewählt
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
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

        /// <summary>
        /// Rekombinator ausgewählt
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
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

        /// <summary>
        /// Raumfahrer und Raumschiff in bestimmter Höhe auf den Hintergrund zeichnen
        /// </summary>
        /// <param name="x">Höhe</param>
        private void setzeRaumfahrer(int x)
        {
            setzeRaumschiff(0, 0);
            gBuffer.DrawImage(bmpRaumfahrer, x, 590, 25, 50);
            pnl_Animation.CreateGraphics().DrawImageUnscaled(_backBuffer, 0, 0);
        }

        /// <summary>
        /// Mondlandungsssimulationsrunde durchlaufen
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void OnMondlandungsSimulationTurn(object sender, EventArgs e)
        {
            MondlandungsSimulationEventArgs mondlandungsArgs = e as MondlandungsSimulationEventArgs;
            lbl_AktGeschwindigkeit.Text = Convert.ToString(mondlandungsArgs.Raumschiff.Geschwindigkeit);
            lbl_AktHoehe.Text = Convert.ToString(mondlandungsArgs.Raumschiff.Hoehe);
            lbl_AktSchub.Text = Convert.ToString(mondlandungsArgs.Schub);
            lbl_AktTank.Text = Convert.ToString(mondlandungsArgs.Raumschiff.Treibstoff);
            Application.DoEvents();
            if (!closingApplication)
            {
                float floatHoehe = letzteHoehe;
                //Raumschiff fliegt aufwärts
                if (mondlandungsArgs.Raumschiff.Geschwindigkeit > 0)
                    while (floatHoehe < mondlandungsArgs.Raumschiff.Hoehe)
                    {
                        floatHoehe += mondlandungsArgs.Raumschiff.Geschwindigkeit / 10.0f;
                        System.Threading.Thread.Sleep(10);
                        setzeRaumschiff(Convert.ToInt32(floatHoehe), mondlandungsArgs.Schub);
                    }
                //Raumschiff fliegt abwärts
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


                //Raumschiff ist gelandet
                if (letzteHoehe <= 0)
                {
                    if ((mondlandungsArgs.Raumschiff.Geschwindigkeit + 10) < 0)
                    {
                        bmpRaumschiff = bmpRaumschiffKaputt;
                        setzeRaumschiff(0, 0);
                    }
                    else
                    {
                        //wegsehen: ugly code!
                        //Raumfahrer-Animation
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
                        //end of ugly code!
                    }
                }
            }
             
        }

        /// <summary>
        /// Abspielen einer Mondlandung mit aus Populationsliste gewähltem Chromosom
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
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

        /// <summary>
        /// Simulationsdurchlauf abbrechen
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void btn_SimAbbrechen_Click(object sender, EventArgs e)
        {
            simulationAbbrechen = true;
        }

        /// <summary>
        /// Gewicht des Raumfahrers zum Raumschiffgewicht hinzuzählen / abziehen
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void gewichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
        }

        /// <summary>
        /// Abbrechen evtl. laufender Simulation beim Beenden des Programms.
        /// </summary>
        /// <param name="sender">aufrufendes Objekt</param>
        /// <param name="e">EreignisObjekt</param>
        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            simulationAbbrechen = true;
            closingApplication = true;
        }
    }

}

 