namespace GeneticAlgorithmsGUI
{
    partial class GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.mnu_Menue = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Einstellungen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_RaumfahrerGewicht = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Simulation = new System.Windows.Forms.GroupBox();
            this.btn_SimAbbrechen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Fitness = new System.Windows.Forms.TextBox();
            this.btn_AutoSim = new System.Windows.Forms.Button();
            this.lbl_Verlustrate = new System.Windows.Forms.Label();
            this.lbl_Mutationsrate = new System.Windows.Forms.Label();
            this.lbl_Duplikationsrate = new System.Windows.Forms.Label();
            this.txt_Verlustrate = new System.Windows.Forms.TextBox();
            this.txt_Mutationsrate = new System.Windows.Forms.TextBox();
            this.txt_Duplikationsrate = new System.Windows.Forms.TextBox();
            this.btn_Zuruecksetzen = new System.Windows.Forms.Button();
            this.lbl_Rundenazahl = new System.Windows.Forms.Label();
            this.txt_Rundenazahl = new System.Windows.Forms.TextBox();
            this.btn_Simuliere = new System.Windows.Forms.Button();
            this.lbl_Selektor = new System.Windows.Forms.Label();
            this.cmb_Selektor = new System.Windows.Forms.ComboBox();
            this.lbl_Chromosomlaenge = new System.Windows.Forms.Label();
            this.txt_Chromosomlaenge = new System.Windows.Forms.TextBox();
            this.lbl_Rekombinator = new System.Windows.Forms.Label();
            this.cmb_Rekombinator = new System.Windows.Forms.ComboBox();
            this.lbl_Hoehe = new System.Windows.Forms.Label();
            this.lbl_Treibstoff = new System.Windows.Forms.Label();
            this.lbl_Gewicht = new System.Windows.Forms.Label();
            this.txt_Hoehe = new System.Windows.Forms.TextBox();
            this.txt_Treibstoff = new System.Windows.Forms.TextBox();
            this.txt_Gewicht = new System.Windows.Forms.TextBox();
            this.gb_Population = new System.Windows.Forms.GroupBox();
            this.btn_Abspielen = new System.Windows.Forms.Button();
            this.dgv_Population = new System.Windows.Forms.DataGridView();
            this.cLaenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFitness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Simulationsiverlauf = new System.Windows.Forms.GroupBox();
            this.chk_Live = new System.Windows.Forms.CheckBox();
            this.chk_maxFitness = new System.Windows.Forms.CheckBox();
            this.chk_minFitness = new System.Windows.Forms.CheckBox();
            this.zgc_Simulationsgraph = new ZedGraph.ZedGraphControl();
            this.chk_Laenge = new System.Windows.Forms.CheckBox();
            this.chk_AVGFitness = new System.Windows.Forms.CheckBox();
            this.pnl_Animation = new System.Windows.Forms.Panel();
            this.lbl_AktGeschwindigkeit = new System.Windows.Forms.Label();
            this.lbl_AnzGeschwindigkeit = new System.Windows.Forms.Label();
            this.lbl_AnzHoehe = new System.Windows.Forms.Label();
            this.lbl_AktHoehe = new System.Windows.Forms.Label();
            this.lbl_AktSchub = new System.Windows.Forms.Label();
            this.lbl_AnzSchub = new System.Windows.Forms.Label();
            this.lbl_AktTank = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnu_Menue.SuspendLayout();
            this.gb_Simulation.SuspendLayout();
            this.gb_Population.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Population)).BeginInit();
            this.gb_Simulationsiverlauf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu_Menue
            // 
            this.mnu_Menue.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_Menue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.mnu_Menue.Location = new System.Drawing.Point(0, 0);
            this.mnu_Menue.Name = "mnu_Menue";
            this.mnu_Menue.Size = new System.Drawing.Size(990, 24);
            this.mnu_Menue.TabIndex = 9;
            this.mnu_Menue.Text = "mnu_Menue";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Einstellungen,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // tsmi_Einstellungen
            // 
            this.tsmi_Einstellungen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_RaumfahrerGewicht});
            this.tsmi_Einstellungen.Name = "tsmi_Einstellungen";
            this.tsmi_Einstellungen.Size = new System.Drawing.Size(148, 22);
            this.tsmi_Einstellungen.Text = "Einstellungen";
            // 
            // tsmi_RaumfahrerGewicht
            // 
            this.tsmi_RaumfahrerGewicht.Name = "tsmi_RaumfahrerGewicht";
            this.tsmi_RaumfahrerGewicht.Size = new System.Drawing.Size(183, 22);
            this.tsmi_RaumfahrerGewicht.Text = "Raumfahrer Gewicht";
            this.tsmi_RaumfahrerGewicht.Click += new System.EventHandler(this.gewichtToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // gb_Simulation
            // 
            this.gb_Simulation.Controls.Add(this.btn_SimAbbrechen);
            this.gb_Simulation.Controls.Add(this.label1);
            this.gb_Simulation.Controls.Add(this.txt_Fitness);
            this.gb_Simulation.Controls.Add(this.btn_AutoSim);
            this.gb_Simulation.Controls.Add(this.lbl_Verlustrate);
            this.gb_Simulation.Controls.Add(this.lbl_Mutationsrate);
            this.gb_Simulation.Controls.Add(this.lbl_Duplikationsrate);
            this.gb_Simulation.Controls.Add(this.txt_Verlustrate);
            this.gb_Simulation.Controls.Add(this.txt_Mutationsrate);
            this.gb_Simulation.Controls.Add(this.txt_Duplikationsrate);
            this.gb_Simulation.Controls.Add(this.btn_Zuruecksetzen);
            this.gb_Simulation.Controls.Add(this.lbl_Rundenazahl);
            this.gb_Simulation.Controls.Add(this.txt_Rundenazahl);
            this.gb_Simulation.Controls.Add(this.btn_Simuliere);
            this.gb_Simulation.Controls.Add(this.lbl_Selektor);
            this.gb_Simulation.Controls.Add(this.cmb_Selektor);
            this.gb_Simulation.Controls.Add(this.lbl_Chromosomlaenge);
            this.gb_Simulation.Controls.Add(this.txt_Chromosomlaenge);
            this.gb_Simulation.Controls.Add(this.lbl_Rekombinator);
            this.gb_Simulation.Controls.Add(this.cmb_Rekombinator);
            this.gb_Simulation.Controls.Add(this.lbl_Hoehe);
            this.gb_Simulation.Controls.Add(this.lbl_Treibstoff);
            this.gb_Simulation.Controls.Add(this.lbl_Gewicht);
            this.gb_Simulation.Controls.Add(this.txt_Hoehe);
            this.gb_Simulation.Controls.Add(this.txt_Treibstoff);
            this.gb_Simulation.Controls.Add(this.txt_Gewicht);
            this.gb_Simulation.Location = new System.Drawing.Point(5, 36);
            this.gb_Simulation.Name = "gb_Simulation";
            this.gb_Simulation.Size = new System.Drawing.Size(674, 102);
            this.gb_Simulation.TabIndex = 16;
            this.gb_Simulation.TabStop = false;
            this.gb_Simulation.Text = "Simulationsparameter";
            // 
            // btn_SimAbbrechen
            // 
            this.btn_SimAbbrechen.Location = new System.Drawing.Point(561, 67);
            this.btn_SimAbbrechen.Name = "btn_SimAbbrechen";
            this.btn_SimAbbrechen.Size = new System.Drawing.Size(86, 23);
            this.btn_SimAbbrechen.TabIndex = 41;
            this.btn_SimAbbrechen.Text = "Abbrechen";
            this.btn_SimAbbrechen.UseVisualStyleBackColor = true;
            this.btn_SimAbbrechen.Click += new System.EventHandler(this.btn_SimAbbrechen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Δ Fitness";
            // 
            // txt_Fitness
            // 
            this.txt_Fitness.Location = new System.Drawing.Point(614, 20);
            this.txt_Fitness.Name = "txt_Fitness";
            this.txt_Fitness.Size = new System.Drawing.Size(33, 20);
            this.txt_Fitness.TabIndex = 39;
            this.txt_Fitness.Text = "0,3";
            this.txt_Fitness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Fitness.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // btn_AutoSim
            // 
            this.btn_AutoSim.Location = new System.Drawing.Point(561, 43);
            this.btn_AutoSim.Name = "btn_AutoSim";
            this.btn_AutoSim.Size = new System.Drawing.Size(86, 23);
            this.btn_AutoSim.TabIndex = 38;
            this.btn_AutoSim.Text = "AutoSim";
            this.btn_AutoSim.UseVisualStyleBackColor = true;
            this.btn_AutoSim.Click += new System.EventHandler(this.btn_Simuliere_Click);
            // 
            // lbl_Verlustrate
            // 
            this.lbl_Verlustrate.AutoSize = true;
            this.lbl_Verlustrate.Location = new System.Drawing.Point(340, 75);
            this.lbl_Verlustrate.Name = "lbl_Verlustrate";
            this.lbl_Verlustrate.Size = new System.Drawing.Size(57, 13);
            this.lbl_Verlustrate.TabIndex = 37;
            this.lbl_Verlustrate.Text = "Verlustrate";
            // 
            // lbl_Mutationsrate
            // 
            this.lbl_Mutationsrate.AutoSize = true;
            this.lbl_Mutationsrate.Location = new System.Drawing.Point(326, 49);
            this.lbl_Mutationsrate.Name = "lbl_Mutationsrate";
            this.lbl_Mutationsrate.Size = new System.Drawing.Size(71, 13);
            this.lbl_Mutationsrate.TabIndex = 36;
            this.lbl_Mutationsrate.Text = "Mutationsrate";
            // 
            // lbl_Duplikationsrate
            // 
            this.lbl_Duplikationsrate.AutoSize = true;
            this.lbl_Duplikationsrate.Location = new System.Drawing.Point(314, 22);
            this.lbl_Duplikationsrate.Name = "lbl_Duplikationsrate";
            this.lbl_Duplikationsrate.Size = new System.Drawing.Size(83, 13);
            this.lbl_Duplikationsrate.TabIndex = 35;
            this.lbl_Duplikationsrate.Text = "Duplikationsrate";
            // 
            // txt_Verlustrate
            // 
            this.txt_Verlustrate.Location = new System.Drawing.Point(403, 72);
            this.txt_Verlustrate.Name = "txt_Verlustrate";
            this.txt_Verlustrate.Size = new System.Drawing.Size(55, 20);
            this.txt_Verlustrate.TabIndex = 34;
            this.txt_Verlustrate.Text = "0,000";
            this.txt_Verlustrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Verlustrate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // txt_Mutationsrate
            // 
            this.txt_Mutationsrate.Location = new System.Drawing.Point(403, 47);
            this.txt_Mutationsrate.Name = "txt_Mutationsrate";
            this.txt_Mutationsrate.Size = new System.Drawing.Size(55, 20);
            this.txt_Mutationsrate.TabIndex = 33;
            this.txt_Mutationsrate.Text = "0,010";
            this.txt_Mutationsrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Mutationsrate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // txt_Duplikationsrate
            // 
            this.txt_Duplikationsrate.Location = new System.Drawing.Point(403, 19);
            this.txt_Duplikationsrate.Name = "txt_Duplikationsrate";
            this.txt_Duplikationsrate.Size = new System.Drawing.Size(55, 20);
            this.txt_Duplikationsrate.TabIndex = 32;
            this.txt_Duplikationsrate.Text = "0,000";
            this.txt_Duplikationsrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Duplikationsrate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // btn_Zuruecksetzen
            // 
            this.btn_Zuruecksetzen.Location = new System.Drawing.Point(469, 67);
            this.btn_Zuruecksetzen.Name = "btn_Zuruecksetzen";
            this.btn_Zuruecksetzen.Size = new System.Drawing.Size(86, 23);
            this.btn_Zuruecksetzen.TabIndex = 31;
            this.btn_Zuruecksetzen.Text = "Zurücksetzen";
            this.btn_Zuruecksetzen.UseVisualStyleBackColor = true;
            this.btn_Zuruecksetzen.Click += new System.EventHandler(this.btn_Zuruecksetzten_Click);
            // 
            // lbl_Rundenazahl
            // 
            this.lbl_Rundenazahl.AutoSize = true;
            this.lbl_Rundenazahl.Location = new System.Drawing.Point(464, 22);
            this.lbl_Rundenazahl.Name = "lbl_Rundenazahl";
            this.lbl_Rundenazahl.Size = new System.Drawing.Size(45, 13);
            this.lbl_Rundenazahl.TabIndex = 30;
            this.lbl_Rundenazahl.Text = "Runden";
            // 
            // txt_Rundenazahl
            // 
            this.txt_Rundenazahl.Location = new System.Drawing.Point(512, 19);
            this.txt_Rundenazahl.Name = "txt_Rundenazahl";
            this.txt_Rundenazahl.Size = new System.Drawing.Size(43, 20);
            this.txt_Rundenazahl.TabIndex = 29;
            this.txt_Rundenazahl.Text = "1";
            this.txt_Rundenazahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Rundenazahl.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // btn_Simuliere
            // 
            this.btn_Simuliere.Location = new System.Drawing.Point(469, 43);
            this.btn_Simuliere.Name = "btn_Simuliere";
            this.btn_Simuliere.Size = new System.Drawing.Size(86, 23);
            this.btn_Simuliere.TabIndex = 28;
            this.btn_Simuliere.Text = "Simuliere";
            this.btn_Simuliere.UseVisualStyleBackColor = true;
            this.btn_Simuliere.Click += new System.EventHandler(this.btn_Simuliere_Click);
            // 
            // lbl_Selektor
            // 
            this.lbl_Selektor.AutoSize = true;
            this.lbl_Selektor.Location = new System.Drawing.Point(183, 23);
            this.lbl_Selektor.Name = "lbl_Selektor";
            this.lbl_Selektor.Size = new System.Drawing.Size(46, 13);
            this.lbl_Selektor.TabIndex = 27;
            this.lbl_Selektor.Text = "Selektor";
            // 
            // cmb_Selektor
            // 
            this.cmb_Selektor.FormattingEnabled = true;
            this.cmb_Selektor.Items.AddRange(new object[] {
            "Alpha",
            "PieCake",
            "Random"});
            this.cmb_Selektor.Location = new System.Drawing.Point(235, 19);
            this.cmb_Selektor.Name = "cmb_Selektor";
            this.cmb_Selektor.Size = new System.Drawing.Size(75, 21);
            this.cmb_Selektor.TabIndex = 26;
            this.cmb_Selektor.SelectedIndexChanged += new System.EventHandler(this.cmb_Selektor_SelectedIndexChanged);
            // 
            // lbl_Chromosomlaenge
            // 
            this.lbl_Chromosomlaenge.AutoSize = true;
            this.lbl_Chromosomlaenge.Location = new System.Drawing.Point(141, 75);
            this.lbl_Chromosomlaenge.Name = "lbl_Chromosomlaenge";
            this.lbl_Chromosomlaenge.Size = new System.Drawing.Size(88, 13);
            this.lbl_Chromosomlaenge.TabIndex = 25;
            this.lbl_Chromosomlaenge.Text = "Chromosomlänge";
            // 
            // txt_Chromosomlaenge
            // 
            this.txt_Chromosomlaenge.Location = new System.Drawing.Point(235, 72);
            this.txt_Chromosomlaenge.Name = "txt_Chromosomlaenge";
            this.txt_Chromosomlaenge.Size = new System.Drawing.Size(75, 20);
            this.txt_Chromosomlaenge.TabIndex = 24;
            this.txt_Chromosomlaenge.Text = "5";
            this.txt_Chromosomlaenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Chromosomlaenge.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // lbl_Rekombinator
            // 
            this.lbl_Rekombinator.AutoSize = true;
            this.lbl_Rekombinator.Location = new System.Drawing.Point(156, 49);
            this.lbl_Rekombinator.Name = "lbl_Rekombinator";
            this.lbl_Rekombinator.Size = new System.Drawing.Size(73, 13);
            this.lbl_Rekombinator.TabIndex = 23;
            this.lbl_Rekombinator.Text = "Rekombinator";
            // 
            // cmb_Rekombinator
            // 
            this.cmb_Rekombinator.FormattingEnabled = true;
            this.cmb_Rekombinator.Items.AddRange(new object[] {
            "Crossover",
            "Zip"});
            this.cmb_Rekombinator.Location = new System.Drawing.Point(235, 46);
            this.cmb_Rekombinator.Name = "cmb_Rekombinator";
            this.cmb_Rekombinator.Size = new System.Drawing.Size(75, 21);
            this.cmb_Rekombinator.TabIndex = 22;
            this.cmb_Rekombinator.SelectedIndexChanged += new System.EventHandler(this.cmb_Rekombinator_SelectedIndexChanged);
            // 
            // lbl_Hoehe
            // 
            this.lbl_Hoehe.AutoSize = true;
            this.lbl_Hoehe.Location = new System.Drawing.Point(22, 75);
            this.lbl_Hoehe.Name = "lbl_Hoehe";
            this.lbl_Hoehe.Size = new System.Drawing.Size(33, 13);
            this.lbl_Hoehe.TabIndex = 21;
            this.lbl_Hoehe.Text = "Höhe";
            // 
            // lbl_Treibstoff
            // 
            this.lbl_Treibstoff.AutoSize = true;
            this.lbl_Treibstoff.Location = new System.Drawing.Point(4, 49);
            this.lbl_Treibstoff.Name = "lbl_Treibstoff";
            this.lbl_Treibstoff.Size = new System.Drawing.Size(51, 13);
            this.lbl_Treibstoff.TabIndex = 20;
            this.lbl_Treibstoff.Text = "Treibstoff";
            // 
            // lbl_Gewicht
            // 
            this.lbl_Gewicht.AutoSize = true;
            this.lbl_Gewicht.Location = new System.Drawing.Point(9, 23);
            this.lbl_Gewicht.Name = "lbl_Gewicht";
            this.lbl_Gewicht.Size = new System.Drawing.Size(46, 13);
            this.lbl_Gewicht.TabIndex = 19;
            this.lbl_Gewicht.Text = "Gewicht";
            // 
            // txt_Hoehe
            // 
            this.txt_Hoehe.Location = new System.Drawing.Point(61, 72);
            this.txt_Hoehe.Name = "txt_Hoehe";
            this.txt_Hoehe.Size = new System.Drawing.Size(75, 20);
            this.txt_Hoehe.TabIndex = 18;
            this.txt_Hoehe.Text = "100";
            this.txt_Hoehe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Hoehe.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // txt_Treibstoff
            // 
            this.txt_Treibstoff.Location = new System.Drawing.Point(61, 46);
            this.txt_Treibstoff.Name = "txt_Treibstoff";
            this.txt_Treibstoff.Size = new System.Drawing.Size(75, 20);
            this.txt_Treibstoff.TabIndex = 17;
            this.txt_Treibstoff.Text = "100";
            this.txt_Treibstoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Treibstoff.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // txt_Gewicht
            // 
            this.txt_Gewicht.Location = new System.Drawing.Point(61, 20);
            this.txt_Gewicht.Name = "txt_Gewicht";
            this.txt_Gewicht.Size = new System.Drawing.Size(75, 20);
            this.txt_Gewicht.TabIndex = 16;
            this.txt_Gewicht.Text = "10";
            this.txt_Gewicht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Gewicht.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // gb_Population
            // 
            this.gb_Population.Controls.Add(this.btn_Abspielen);
            this.gb_Population.Controls.Add(this.dgv_Population);
            this.gb_Population.Location = new System.Drawing.Point(5, 510);
            this.gb_Population.Name = "gb_Population";
            this.gb_Population.Size = new System.Drawing.Size(674, 182);
            this.gb_Population.TabIndex = 17;
            this.gb_Population.TabStop = false;
            this.gb_Population.Text = "Population";
            // 
            // btn_Abspielen
            // 
            this.btn_Abspielen.Enabled = false;
            this.btn_Abspielen.Location = new System.Drawing.Point(591, 139);
            this.btn_Abspielen.Name = "btn_Abspielen";
            this.btn_Abspielen.Size = new System.Drawing.Size(75, 23);
            this.btn_Abspielen.TabIndex = 19;
            this.btn_Abspielen.Text = "Abspielen";
            this.btn_Abspielen.UseVisualStyleBackColor = true;
            this.btn_Abspielen.Click += new System.EventHandler(this.btn_Abspielen_Click);
            // 
            // dgv_Population
            // 
            this.dgv_Population.AllowUserToAddRows = false;
            this.dgv_Population.AllowUserToDeleteRows = false;
            this.dgv_Population.AllowUserToResizeColumns = false;
            this.dgv_Population.AllowUserToResizeRows = false;
            this.dgv_Population.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Population.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Population.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLaenge,
            this.cGene,
            this.cFitness});
            this.dgv_Population.Location = new System.Drawing.Point(7, 19);
            this.dgv_Population.MultiSelect = false;
            this.dgv_Population.Name = "dgv_Population";
            this.dgv_Population.ReadOnly = true;
            this.dgv_Population.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Population.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Population.Size = new System.Drawing.Size(578, 155);
            this.dgv_Population.TabIndex = 18;
            // 
            // cLaenge
            // 
            this.cLaenge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cLaenge.HeaderText = "Länge";
            this.cLaenge.Name = "cLaenge";
            this.cLaenge.ReadOnly = true;
            this.cLaenge.Width = 62;
            // 
            // cGene
            // 
            this.cGene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cGene.HeaderText = "Gene";
            this.cGene.Name = "cGene";
            this.cGene.ReadOnly = true;
            // 
            // cFitness
            // 
            this.cFitness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cFitness.HeaderText = "Fitness";
            this.cFitness.Name = "cFitness";
            this.cFitness.ReadOnly = true;
            this.cFitness.Width = 65;
            // 
            // gb_Simulationsiverlauf
            // 
            this.gb_Simulationsiverlauf.Controls.Add(this.chk_Live);
            this.gb_Simulationsiverlauf.Controls.Add(this.chk_maxFitness);
            this.gb_Simulationsiverlauf.Controls.Add(this.chk_minFitness);
            this.gb_Simulationsiverlauf.Controls.Add(this.zgc_Simulationsgraph);
            this.gb_Simulationsiverlauf.Controls.Add(this.chk_Laenge);
            this.gb_Simulationsiverlauf.Controls.Add(this.chk_AVGFitness);
            this.gb_Simulationsiverlauf.Location = new System.Drawing.Point(5, 144);
            this.gb_Simulationsiverlauf.Name = "gb_Simulationsiverlauf";
            this.gb_Simulationsiverlauf.Size = new System.Drawing.Size(674, 360);
            this.gb_Simulationsiverlauf.TabIndex = 18;
            this.gb_Simulationsiverlauf.TabStop = false;
            this.gb_Simulationsiverlauf.Text = "Simulationsverlauf";
            // 
            // chk_Live
            // 
            this.chk_Live.AutoSize = true;
            this.chk_Live.Location = new System.Drawing.Point(574, 337);
            this.chk_Live.Name = "chk_Live";
            this.chk_Live.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Live.Size = new System.Drawing.Size(94, 17);
            this.chk_Live.TabIndex = 6;
            this.chk_Live.Text = "Live Zeichnen";
            this.chk_Live.UseVisualStyleBackColor = true;
            // 
            // chk_maxFitness
            // 
            this.chk_maxFitness.AutoSize = true;
            this.chk_maxFitness.Location = new System.Drawing.Point(334, 338);
            this.chk_maxFitness.Name = "chk_maxFitness";
            this.chk_maxFitness.Size = new System.Drawing.Size(81, 17);
            this.chk_maxFitness.TabIndex = 5;
            this.chk_maxFitness.Text = "max Fitness";
            this.chk_maxFitness.UseVisualStyleBackColor = true;
            this.chk_maxFitness.CheckedChanged += new System.EventHandler(this.chk_maxFitness_CheckedChanged);
            // 
            // chk_minFitness
            // 
            this.chk_minFitness.AutoSize = true;
            this.chk_minFitness.Location = new System.Drawing.Point(250, 338);
            this.chk_minFitness.Name = "chk_minFitness";
            this.chk_minFitness.Size = new System.Drawing.Size(78, 17);
            this.chk_minFitness.TabIndex = 4;
            this.chk_minFitness.Text = "min Fitness";
            this.chk_minFitness.UseVisualStyleBackColor = true;
            this.chk_minFitness.CheckedChanged += new System.EventHandler(this.chk_minFitness_CheckedChanged);
            // 
            // zgc_Simulationsgraph
            // 
            this.zgc_Simulationsgraph.Location = new System.Drawing.Point(6, 16);
            this.zgc_Simulationsgraph.Name = "zgc_Simulationsgraph";
            this.zgc_Simulationsgraph.ScrollGrace = 0;
            this.zgc_Simulationsgraph.ScrollMaxX = 0;
            this.zgc_Simulationsgraph.ScrollMaxY = 0;
            this.zgc_Simulationsgraph.ScrollMaxY2 = 0;
            this.zgc_Simulationsgraph.ScrollMinX = 0;
            this.zgc_Simulationsgraph.ScrollMinY = 0;
            this.zgc_Simulationsgraph.ScrollMinY2 = 0;
            this.zgc_Simulationsgraph.Size = new System.Drawing.Size(662, 316);
            this.zgc_Simulationsgraph.TabIndex = 0;
            // 
            // chk_Laenge
            // 
            this.chk_Laenge.AutoSize = true;
            this.chk_Laenge.Location = new System.Drawing.Point(79, 338);
            this.chk_Laenge.Name = "chk_Laenge";
            this.chk_Laenge.Size = new System.Drawing.Size(67, 17);
            this.chk_Laenge.TabIndex = 2;
            this.chk_Laenge.Text = "Ø Länge";
            this.chk_Laenge.UseVisualStyleBackColor = true;
            this.chk_Laenge.CheckedChanged += new System.EventHandler(this.chk_Laenge_CheckedChanged);
            // 
            // chk_AVGFitness
            // 
            this.chk_AVGFitness.AutoSize = true;
            this.chk_AVGFitness.Checked = true;
            this.chk_AVGFitness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_AVGFitness.Location = new System.Drawing.Point(7, 338);
            this.chk_AVGFitness.Name = "chk_AVGFitness";
            this.chk_AVGFitness.Size = new System.Drawing.Size(70, 17);
            this.chk_AVGFitness.TabIndex = 1;
            this.chk_AVGFitness.Text = "Ø Fitness";
            this.chk_AVGFitness.UseVisualStyleBackColor = true;
            this.chk_AVGFitness.CheckedChanged += new System.EventHandler(this.chk_AVGFitness_CheckedChanged);
            // 
            // pnl_Animation
            // 
            this.pnl_Animation.Location = new System.Drawing.Point(685, 42);
            this.pnl_Animation.Name = "pnl_Animation";
            this.pnl_Animation.Size = new System.Drawing.Size(300, 650);
            this.pnl_Animation.TabIndex = 19;
            this.pnl_Animation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Animation_Paint);
            // 
            // lbl_AktGeschwindigkeit
            // 
            this.lbl_AktGeschwindigkeit.AutoSize = true;
            this.lbl_AktGeschwindigkeit.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AktGeschwindigkeit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AktGeschwindigkeit.Location = new System.Drawing.Point(878, 10);
            this.lbl_AktGeschwindigkeit.Name = "lbl_AktGeschwindigkeit";
            this.lbl_AktGeschwindigkeit.Size = new System.Drawing.Size(23, 26);
            this.lbl_AktGeschwindigkeit.TabIndex = 0;
            this.lbl_AktGeschwindigkeit.Text = "0";
            // 
            // lbl_AnzGeschwindigkeit
            // 
            this.lbl_AnzGeschwindigkeit.AutoSize = true;
            this.lbl_AnzGeschwindigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnzGeschwindigkeit.Location = new System.Drawing.Point(851, 10);
            this.lbl_AnzGeschwindigkeit.Name = "lbl_AnzGeschwindigkeit";
            this.lbl_AnzGeschwindigkeit.Size = new System.Drawing.Size(31, 26);
            this.lbl_AnzGeschwindigkeit.TabIndex = 20;
            this.lbl_AnzGeschwindigkeit.Text = "v:";
            // 
            // lbl_AnzHoehe
            // 
            this.lbl_AnzHoehe.AutoSize = true;
            this.lbl_AnzHoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_AnzHoehe.Location = new System.Drawing.Point(771, 10);
            this.lbl_AnzHoehe.Name = "lbl_AnzHoehe";
            this.lbl_AnzHoehe.Size = new System.Drawing.Size(32, 26);
            this.lbl_AnzHoehe.TabIndex = 21;
            this.lbl_AnzHoehe.Text = "h:";
            // 
            // lbl_AktHoehe
            // 
            this.lbl_AktHoehe.AutoSize = true;
            this.lbl_AktHoehe.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lbl_AktHoehe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AktHoehe.Location = new System.Drawing.Point(798, 10);
            this.lbl_AktHoehe.Name = "lbl_AktHoehe";
            this.lbl_AktHoehe.Size = new System.Drawing.Size(23, 26);
            this.lbl_AktHoehe.TabIndex = 22;
            this.lbl_AktHoehe.Text = "0";
            // 
            // lbl_AktSchub
            // 
            this.lbl_AktSchub.AutoSize = true;
            this.lbl_AktSchub.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lbl_AktSchub.Location = new System.Drawing.Point(955, 11);
            this.lbl_AktSchub.Name = "lbl_AktSchub";
            this.lbl_AktSchub.Size = new System.Drawing.Size(23, 26);
            this.lbl_AktSchub.TabIndex = 0;
            this.lbl_AktSchub.Text = "0";
            // 
            // lbl_AnzSchub
            // 
            this.lbl_AnzSchub.AutoSize = true;
            this.lbl_AnzSchub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_AnzSchub.Location = new System.Drawing.Point(928, 10);
            this.lbl_AnzSchub.Name = "lbl_AnzSchub";
            this.lbl_AnzSchub.Size = new System.Drawing.Size(32, 26);
            this.lbl_AnzSchub.TabIndex = 0;
            this.lbl_AnzSchub.Text = "a:";
            // 
            // lbl_AktTank
            // 
            this.lbl_AktTank.AutoSize = true;
            this.lbl_AktTank.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lbl_AktTank.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AktTank.Location = new System.Drawing.Point(723, 8);
            this.lbl_AktTank.Name = "lbl_AktTank";
            this.lbl_AktTank.Size = new System.Drawing.Size(23, 26);
            this.lbl_AktTank.TabIndex = 24;
            this.lbl_AktTank.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 697);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_AktTank);
            this.Controls.Add(this.lbl_AnzSchub);
            this.Controls.Add(this.lbl_AktSchub);
            this.Controls.Add(this.lbl_AktHoehe);
            this.Controls.Add(this.lbl_AnzHoehe);
            this.Controls.Add(this.lbl_AnzGeschwindigkeit);
            this.Controls.Add(this.pnl_Animation);
            this.Controls.Add(this.lbl_AktGeschwindigkeit);
            this.Controls.Add(this.gb_Simulationsiverlauf);
            this.Controls.Add(this.gb_Population);
            this.Controls.Add(this.gb_Simulation);
            this.Controls.Add(this.mnu_Menue);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_Menue;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mondlandung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.mnu_Menue.ResumeLayout(false);
            this.mnu_Menue.PerformLayout();
            this.gb_Simulation.ResumeLayout(false);
            this.gb_Simulation.PerformLayout();
            this.gb_Population.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Population)).EndInit();
            this.gb_Simulationsiverlauf.ResumeLayout(false);
            this.gb_Simulationsiverlauf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_Menue;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_Simulation;
        private System.Windows.Forms.Label lbl_Selektor;
        private System.Windows.Forms.ComboBox cmb_Selektor;
        private System.Windows.Forms.Label lbl_Chromosomlaenge;
        private System.Windows.Forms.TextBox txt_Chromosomlaenge;
        private System.Windows.Forms.Label lbl_Rekombinator;
        private System.Windows.Forms.ComboBox cmb_Rekombinator;
        private System.Windows.Forms.Label lbl_Hoehe;
        private System.Windows.Forms.Label lbl_Treibstoff;
        private System.Windows.Forms.Label lbl_Gewicht;
        private System.Windows.Forms.TextBox txt_Hoehe;
        private System.Windows.Forms.TextBox txt_Treibstoff;
        private System.Windows.Forms.TextBox txt_Gewicht;
        private System.Windows.Forms.GroupBox gb_Population;
        private System.Windows.Forms.DataGridView dgv_Population;
        private System.Windows.Forms.TextBox txt_Rundenazahl;
        private System.Windows.Forms.Button btn_Simuliere;
        private System.Windows.Forms.Label lbl_Rundenazahl;
        private System.Windows.Forms.Button btn_Zuruecksetzen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLaenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGene;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFitness;
        private System.Windows.Forms.GroupBox gb_Simulationsiverlauf;
        private ZedGraph.ZedGraphControl zgc_Simulationsgraph;
        private System.Windows.Forms.CheckBox chk_AVGFitness;
        private System.Windows.Forms.CheckBox chk_Laenge;
        private System.Windows.Forms.CheckBox chk_maxFitness;
        private System.Windows.Forms.CheckBox chk_minFitness;
        private System.Windows.Forms.Label lbl_Verlustrate;
        private System.Windows.Forms.Label lbl_Mutationsrate;
        private System.Windows.Forms.Label lbl_Duplikationsrate;
        private System.Windows.Forms.TextBox txt_Verlustrate;
        private System.Windows.Forms.TextBox txt_Mutationsrate;
        private System.Windows.Forms.TextBox txt_Duplikationsrate;
        private System.Windows.Forms.Panel pnl_Animation;
        private System.Windows.Forms.Button btn_Abspielen;
        private System.Windows.Forms.Button btn_AutoSim;
        private System.Windows.Forms.Label lbl_AktGeschwindigkeit;
        private System.Windows.Forms.Label lbl_AnzGeschwindigkeit;
        private System.Windows.Forms.Label lbl_AnzHoehe;
        private System.Windows.Forms.Label lbl_AktHoehe;
        private System.Windows.Forms.Label lbl_AktSchub;
        private System.Windows.Forms.Label lbl_AnzSchub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Fitness;
        private System.Windows.Forms.Button btn_SimAbbrechen;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Einstellungen;
        private System.Windows.Forms.ToolStripMenuItem tsmi_RaumfahrerGewicht;
        private System.Windows.Forms.Label lbl_AktTank;
        private System.Windows.Forms.CheckBox chk_Live;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}