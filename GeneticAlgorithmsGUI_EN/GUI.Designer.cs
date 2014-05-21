namespace GeneticAlgorithmsGUI_EN
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SpacemanHeight = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Simulation = new System.Windows.Forms.GroupBox();
            this.btn_SimAbort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Fitness = new System.Windows.Forms.TextBox();
            this.btn_AutoSim = new System.Windows.Forms.Button();
            this.lbl_LossRate = new System.Windows.Forms.Label();
            this.lbl_MutationsRate = new System.Windows.Forms.Label();
            this.lbl_DuplicationsRate = new System.Windows.Forms.Label();
            this.txt_LossRate = new System.Windows.Forms.TextBox();
            this.txt_MutationsRate = new System.Windows.Forms.TextBox();
            this.txt_DuplicationsRate = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_RoundNumber = new System.Windows.Forms.Label();
            this.txt_RoundNumber = new System.Windows.Forms.TextBox();
            this.btn_Simulate = new System.Windows.Forms.Button();
            this.lbl_Selector = new System.Windows.Forms.Label();
            this.cmb_Selector = new System.Windows.Forms.ComboBox();
            this.lbl_ChromosomeLength = new System.Windows.Forms.Label();
            this.txt_ChromosomeLength = new System.Windows.Forms.TextBox();
            this.lbl_Recombinator = new System.Windows.Forms.Label();
            this.cmb_Recombinator = new System.Windows.Forms.ComboBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Engine = new System.Windows.Forms.Label();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Engine = new System.Windows.Forms.TextBox();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.gb_Population = new System.Windows.Forms.GroupBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.dgv_Population = new System.Windows.Forms.DataGridView();
            this.cLaenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFitness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_SimulationResults = new System.Windows.Forms.GroupBox();
            this.chk_Live = new System.Windows.Forms.CheckBox();
            this.chk_maxFitness = new System.Windows.Forms.CheckBox();
            this.chk_minFitness = new System.Windows.Forms.CheckBox();
            this.zgc_Simulationsgraph = new ZedGraph.ZedGraphControl();
            this.chk_Length = new System.Windows.Forms.CheckBox();
            this.chk_AVGFitness = new System.Windows.Forms.CheckBox();
            this.pnl_Animation = new System.Windows.Forms.Panel();
            this.lbl_SpeedValue = new System.Windows.Forms.Label();
            this.lbl_SpeedLabel = new System.Windows.Forms.Label();
            this.lbl_HeightLabel = new System.Windows.Forms.Label();
            this.lbl_HeightValue = new System.Windows.Forms.Label();
            this.lbl_ThrustValue = new System.Windows.Forms.Label();
            this.lbl_ThrustLabel = new System.Windows.Forms.Label();
            this.lbl_TankValue = new System.Windows.Forms.Label();
            this.TankLabel = new System.Windows.Forms.PictureBox();
            this.mnu_Menue.SuspendLayout();
            this.gb_Simulation.SuspendLayout();
            this.gb_Population.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Population)).BeginInit();
            this.gb_SimulationResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TankLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu_Menue
            // 
            this.mnu_Menue.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_Menue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnu_Menue.Location = new System.Drawing.Point(0, 0);
            this.mnu_Menue.Name = "mnu_Menue";
            this.mnu_Menue.Size = new System.Drawing.Size(990, 24);
            this.mnu_Menue.TabIndex = 9;
            this.mnu_Menue.Text = "mnu_Menue";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Settings,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmi_Einstellungen
            // 
            this.tsmi_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_SpacemanHeight});
            this.tsmi_Settings.Name = "tsmi_Einstellungen";
            this.tsmi_Settings.Size = new System.Drawing.Size(116, 22);
            this.tsmi_Settings.Text = "Settings";
            // 
            // tsmi_RaumfahrerGewicht
            // 
            this.tsmi_SpacemanHeight.Name = "tsmi_RaumfahrerGewicht";
            this.tsmi_SpacemanHeight.Size = new System.Drawing.Size(170, 22);
            this.tsmi_SpacemanHeight.Text = "Spaceman Weight";
            this.tsmi_SpacemanHeight.Click += new System.EventHandler(this.gewichtToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // gb_Simulation
            // 
            this.gb_Simulation.Controls.Add(this.btn_SimAbort);
            this.gb_Simulation.Controls.Add(this.label1);
            this.gb_Simulation.Controls.Add(this.txt_Fitness);
            this.gb_Simulation.Controls.Add(this.btn_AutoSim);
            this.gb_Simulation.Controls.Add(this.lbl_LossRate);
            this.gb_Simulation.Controls.Add(this.lbl_MutationsRate);
            this.gb_Simulation.Controls.Add(this.lbl_DuplicationsRate);
            this.gb_Simulation.Controls.Add(this.txt_LossRate);
            this.gb_Simulation.Controls.Add(this.txt_MutationsRate);
            this.gb_Simulation.Controls.Add(this.txt_DuplicationsRate);
            this.gb_Simulation.Controls.Add(this.btn_Reset);
            this.gb_Simulation.Controls.Add(this.lbl_RoundNumber);
            this.gb_Simulation.Controls.Add(this.txt_RoundNumber);
            this.gb_Simulation.Controls.Add(this.btn_Simulate);
            this.gb_Simulation.Controls.Add(this.lbl_Selector);
            this.gb_Simulation.Controls.Add(this.cmb_Selector);
            this.gb_Simulation.Controls.Add(this.lbl_ChromosomeLength);
            this.gb_Simulation.Controls.Add(this.txt_ChromosomeLength);
            this.gb_Simulation.Controls.Add(this.lbl_Recombinator);
            this.gb_Simulation.Controls.Add(this.cmb_Recombinator);
            this.gb_Simulation.Controls.Add(this.lbl_Height);
            this.gb_Simulation.Controls.Add(this.lbl_Engine);
            this.gb_Simulation.Controls.Add(this.lbl_Weight);
            this.gb_Simulation.Controls.Add(this.txt_Height);
            this.gb_Simulation.Controls.Add(this.txt_Engine);
            this.gb_Simulation.Controls.Add(this.txt_Weight);
            this.gb_Simulation.Location = new System.Drawing.Point(5, 36);
            this.gb_Simulation.Name = "gb_Simulation";
            this.gb_Simulation.Size = new System.Drawing.Size(674, 102);
            this.gb_Simulation.TabIndex = 16;
            this.gb_Simulation.TabStop = false;
            this.gb_Simulation.Text = "Simulation Parameters";
            // 
            // btn_SimAbbrechen
            // 
            this.btn_SimAbort.Location = new System.Drawing.Point(580, 65);
            this.btn_SimAbort.Name = "btn_SimAbbrechen";
            this.btn_SimAbort.Size = new System.Drawing.Size(86, 23);
            this.btn_SimAbort.TabIndex = 41;
            this.btn_SimAbort.Text = "Abort";
            this.btn_SimAbort.UseVisualStyleBackColor = true;
            this.btn_SimAbort.Click += new System.EventHandler(this.btn_SimAbbrechen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Δ Fitness";
            // 
            // txt_Fitness
            // 
            this.txt_Fitness.Location = new System.Drawing.Point(633, 18);
            this.txt_Fitness.Name = "txt_Fitness";
            this.txt_Fitness.Size = new System.Drawing.Size(33, 20);
            this.txt_Fitness.TabIndex = 39;
            this.txt_Fitness.Text = "0,3";
            this.txt_Fitness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Fitness.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // btn_AutoSim
            // 
            this.btn_AutoSim.Location = new System.Drawing.Point(580, 41);
            this.btn_AutoSim.Name = "btn_AutoSim";
            this.btn_AutoSim.Size = new System.Drawing.Size(86, 23);
            this.btn_AutoSim.TabIndex = 38;
            this.btn_AutoSim.Text = "AutoSim";
            this.btn_AutoSim.UseVisualStyleBackColor = true;
            this.btn_AutoSim.Click += new System.EventHandler(this.btn_Simuliere_Click);
            // 
            // lbl_Verlustrate
            // 
            this.lbl_LossRate.AutoSize = true;
            this.lbl_LossRate.Location = new System.Drawing.Point(361, 73);
            this.lbl_LossRate.Name = "lbl_Verlustrate";
            this.lbl_LossRate.Size = new System.Drawing.Size(55, 13);
            this.lbl_LossRate.TabIndex = 37;
            this.lbl_LossRate.Text = "Loss Rate";
            // 
            // lbl_Mutationsrate
            // 
            this.lbl_MutationsRate.AutoSize = true;
            this.lbl_MutationsRate.Location = new System.Drawing.Point(337, 49);
            this.lbl_MutationsRate.Name = "lbl_Mutationsrate";
            this.lbl_MutationsRate.Size = new System.Drawing.Size(79, 13);
            this.lbl_MutationsRate.TabIndex = 36;
            this.lbl_MutationsRate.Text = "Mutations Rate";
            // 
            // lbl_Duplikationsrate
            // 
            this.lbl_DuplicationsRate.AutoSize = true;
            this.lbl_DuplicationsRate.Location = new System.Drawing.Point(328, 20);
            this.lbl_DuplicationsRate.Name = "lbl_Duplikationsrate";
            this.lbl_DuplicationsRate.Size = new System.Drawing.Size(86, 13);
            this.lbl_DuplicationsRate.TabIndex = 35;
            this.lbl_DuplicationsRate.Text = "Duplication Rate";
            // 
            // txt_Verlustrate
            // 
            this.txt_LossRate.Location = new System.Drawing.Point(422, 70);
            this.txt_LossRate.Name = "txt_Verlustrate";
            this.txt_LossRate.Size = new System.Drawing.Size(55, 20);
            this.txt_LossRate.TabIndex = 34;
            this.txt_LossRate.Text = "0,000";
            this.txt_LossRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_LossRate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // txt_Mutationsrate
            // 
            this.txt_MutationsRate.Location = new System.Drawing.Point(422, 45);
            this.txt_MutationsRate.Name = "txt_Mutationsrate";
            this.txt_MutationsRate.Size = new System.Drawing.Size(55, 20);
            this.txt_MutationsRate.TabIndex = 33;
            this.txt_MutationsRate.Text = "0,010";
            this.txt_MutationsRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_MutationsRate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // txt_Duplikationsrate
            // 
            this.txt_DuplicationsRate.Location = new System.Drawing.Point(422, 17);
            this.txt_DuplicationsRate.Name = "txt_Duplikationsrate";
            this.txt_DuplicationsRate.Size = new System.Drawing.Size(55, 20);
            this.txt_DuplicationsRate.TabIndex = 32;
            this.txt_DuplicationsRate.Text = "0,000";
            this.txt_DuplicationsRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DuplicationsRate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Float_Validating);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(488, 65);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 23);
            this.btn_Reset.TabIndex = 31;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Zuruecksetzten_Click);
            // 
            // lbl_RoundNumber
            // 
            this.lbl_RoundNumber.AutoSize = true;
            this.lbl_RoundNumber.Location = new System.Drawing.Point(483, 20);
            this.lbl_RoundNumber.Name = "lbl_RoundNumber";
            this.lbl_RoundNumber.Size = new System.Drawing.Size(44, 13);
            this.lbl_RoundNumber.TabIndex = 30;
            this.lbl_RoundNumber.Text = "Rounds";
            // 
            // txt_RoundNumber
            // 
            this.txt_RoundNumber.Location = new System.Drawing.Point(531, 17);
            this.txt_RoundNumber.Name = "txt_RoundNumber";
            this.txt_RoundNumber.Size = new System.Drawing.Size(43, 20);
            this.txt_RoundNumber.TabIndex = 29;
            this.txt_RoundNumber.Text = "1";
            this.txt_RoundNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_RoundNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // btn_Simulate
            // 
            this.btn_Simulate.Location = new System.Drawing.Point(488, 41);
            this.btn_Simulate.Name = "btn_Simulate";
            this.btn_Simulate.Size = new System.Drawing.Size(86, 23);
            this.btn_Simulate.TabIndex = 28;
            this.btn_Simulate.Text = "Simulate";
            this.btn_Simulate.UseVisualStyleBackColor = true;
            this.btn_Simulate.Click += new System.EventHandler(this.btn_Simuliere_Click);
            // 
            // lbl_Selector
            // 
            this.lbl_Selector.AutoSize = true;
            this.lbl_Selector.Location = new System.Drawing.Point(197, 23);
            this.lbl_Selector.Name = "lbl_Selector";
            this.lbl_Selector.Size = new System.Drawing.Size(46, 13);
            this.lbl_Selector.TabIndex = 27;
            this.lbl_Selector.Text = "Selector";
            // 
            // cmb_Selector
            // 
            this.cmb_Selector.FormattingEnabled = true;
            this.cmb_Selector.Items.AddRange(new object[] {
            "Alpha",
            "PieCake",
            "Random"});
            this.cmb_Selector.Location = new System.Drawing.Point(249, 19);
            this.cmb_Selector.Name = "cmb_Selector";
            this.cmb_Selector.Size = new System.Drawing.Size(75, 21);
            this.cmb_Selector.TabIndex = 26;
            this.cmb_Selector.SelectedIndexChanged += new System.EventHandler(this.cmb_Selektor_SelectedIndexChanged);
            // 
            // lbl_ChromosomeLength
            // 
            this.lbl_ChromosomeLength.AutoSize = true;
            this.lbl_ChromosomeLength.Location = new System.Drawing.Point(142, 75);
            this.lbl_ChromosomeLength.Name = "lbl_ChromosomeLength";
            this.lbl_ChromosomeLength.Size = new System.Drawing.Size(101, 13);
            this.lbl_ChromosomeLength.TabIndex = 25;
            this.lbl_ChromosomeLength.Text = "ChromosomeLength";
            // 
            // txt_ChromosomeLength
            // 
            this.txt_ChromosomeLength.Location = new System.Drawing.Point(249, 72);
            this.txt_ChromosomeLength.Name = "txt_ChromosomeLength";
            this.txt_ChromosomeLength.Size = new System.Drawing.Size(75, 20);
            this.txt_ChromosomeLength.TabIndex = 24;
            this.txt_ChromosomeLength.Text = "5";
            this.txt_ChromosomeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ChromosomeLength.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // lbl_Recombinator
            // 
            this.lbl_Recombinator.AutoSize = true;
            this.lbl_Recombinator.Location = new System.Drawing.Point(170, 48);
            this.lbl_Recombinator.Name = "lbl_Recombinator";
            this.lbl_Recombinator.Size = new System.Drawing.Size(73, 13);
            this.lbl_Recombinator.TabIndex = 23;
            this.lbl_Recombinator.Text = "Recombinator";
            // 
            // cmb_Recombinator
            // 
            this.cmb_Recombinator.FormattingEnabled = true;
            this.cmb_Recombinator.Items.AddRange(new object[] {
            "Crossover",
            "Zip"});
            this.cmb_Recombinator.Location = new System.Drawing.Point(249, 46);
            this.cmb_Recombinator.Name = "cmb_Recombinator";
            this.cmb_Recombinator.Size = new System.Drawing.Size(75, 21);
            this.cmb_Recombinator.TabIndex = 22;
            this.cmb_Recombinator.SelectedIndexChanged += new System.EventHandler(this.cmb_Rekombinator_SelectedIndexChanged);
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(17, 75);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(38, 13);
            this.lbl_Height.TabIndex = 21;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_Engine
            // 
            this.lbl_Engine.AutoSize = true;
            this.lbl_Engine.Location = new System.Drawing.Point(28, 49);
            this.lbl_Engine.Name = "lbl_Engine";
            this.lbl_Engine.Size = new System.Drawing.Size(27, 13);
            this.lbl_Engine.TabIndex = 20;
            this.lbl_Engine.Text = "Fuel";
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Location = new System.Drawing.Point(14, 22);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(41, 13);
            this.lbl_Weight.TabIndex = 19;
            this.lbl_Weight.Text = "Weight";
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(61, 72);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(75, 20);
            this.txt_Height.TabIndex = 18;
            this.txt_Height.Text = "100";
            this.txt_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Height.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // txt_Engine
            // 
            this.txt_Engine.Location = new System.Drawing.Point(61, 46);
            this.txt_Engine.Name = "txt_Engine";
            this.txt_Engine.Size = new System.Drawing.Size(75, 20);
            this.txt_Engine.TabIndex = 17;
            this.txt_Engine.Text = "100";
            this.txt_Engine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Engine.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(61, 20);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(75, 20);
            this.txt_Weight.TabIndex = 16;
            this.txt_Weight.Text = "10";
            this.txt_Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Weight.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Int_Validating);
            // 
            // gb_Population
            // 
            this.gb_Population.Controls.Add(this.btn_Play);
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
            this.btn_Play.Enabled = false;
            this.btn_Play.Location = new System.Drawing.Point(591, 139);
            this.btn_Play.Name = "btn_Abspielen";
            this.btn_Play.Size = new System.Drawing.Size(75, 23);
            this.btn_Play.TabIndex = 19;
            this.btn_Play.TabStop = false;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Abspielen_Click);
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
            // gb_SimulationResults
            // 
            this.gb_SimulationResults.Controls.Add(this.chk_Live);
            this.gb_SimulationResults.Controls.Add(this.chk_maxFitness);
            this.gb_SimulationResults.Controls.Add(this.chk_minFitness);
            this.gb_SimulationResults.Controls.Add(this.zgc_Simulationsgraph);
            this.gb_SimulationResults.Controls.Add(this.chk_Length);
            this.gb_SimulationResults.Controls.Add(this.chk_AVGFitness);
            this.gb_SimulationResults.Location = new System.Drawing.Point(5, 144);
            this.gb_SimulationResults.Name = "gb_SimulationResults";
            this.gb_SimulationResults.Size = new System.Drawing.Size(674, 360);
            this.gb_SimulationResults.TabIndex = 18;
            this.gb_SimulationResults.TabStop = false;
            this.gb_SimulationResults.Text = "Simulation Results";
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
            this.zgc_Simulationsgraph.ScrollGrace = 0D;
            this.zgc_Simulationsgraph.ScrollMaxX = 0D;
            this.zgc_Simulationsgraph.ScrollMaxY = 0D;
            this.zgc_Simulationsgraph.ScrollMaxY2 = 0D;
            this.zgc_Simulationsgraph.ScrollMinX = 0D;
            this.zgc_Simulationsgraph.ScrollMinY = 0D;
            this.zgc_Simulationsgraph.ScrollMinY2 = 0D;
            this.zgc_Simulationsgraph.Size = new System.Drawing.Size(662, 316);
            this.zgc_Simulationsgraph.TabIndex = 0;
            // 
            // chk_Laenge
            // 
            this.chk_Length.AutoSize = true;
            this.chk_Length.Location = new System.Drawing.Point(79, 338);
            this.chk_Length.Name = "chk_Laenge";
            this.chk_Length.Size = new System.Drawing.Size(67, 17);
            this.chk_Length.TabIndex = 2;
            this.chk_Length.Text = "Ø Länge";
            this.chk_Length.UseVisualStyleBackColor = true;
            this.chk_Length.CheckedChanged += new System.EventHandler(this.chk_Duration_CheckedChanged);
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
            this.lbl_SpeedValue.AutoSize = true;
            this.lbl_SpeedValue.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SpeedValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_SpeedValue.Location = new System.Drawing.Point(878, 10);
            this.lbl_SpeedValue.Name = "lbl_AktGeschwindigkeit";
            this.lbl_SpeedValue.Size = new System.Drawing.Size(23, 26);
            this.lbl_SpeedValue.TabIndex = 0;
            this.lbl_SpeedValue.Text = "0";
            // 
            // lbl_AnzGeschwindigkeit
            // 
            this.lbl_SpeedLabel.AutoSize = true;
            this.lbl_SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SpeedLabel.Location = new System.Drawing.Point(851, 10);
            this.lbl_SpeedLabel.Name = "lbl_AnzGeschwindigkeit";
            this.lbl_SpeedLabel.Size = new System.Drawing.Size(31, 26);
            this.lbl_SpeedLabel.TabIndex = 20;
            this.lbl_SpeedLabel.Text = "v:";
            // 
            // lbl_AnzHoehe
            // 
            this.lbl_HeightLabel.AutoSize = true;
            this.lbl_HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeightLabel.Location = new System.Drawing.Point(771, 10);
            this.lbl_HeightLabel.Name = "lbl_AnzHoehe";
            this.lbl_HeightLabel.Size = new System.Drawing.Size(32, 26);
            this.lbl_HeightLabel.TabIndex = 21;
            this.lbl_HeightLabel.Text = "h:";
            // 
            // lbl_AktHoehe
            // 
            this.lbl_HeightValue.AutoSize = true;
            this.lbl_HeightValue.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lbl_HeightValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HeightValue.Location = new System.Drawing.Point(798, 10);
            this.lbl_HeightValue.Name = "lbl_AktHoehe";
            this.lbl_HeightValue.Size = new System.Drawing.Size(23, 26);
            this.lbl_HeightValue.TabIndex = 22;
            this.lbl_HeightValue.Text = "0";
            // 
            // lbl_AktSchub
            // 
            this.lbl_ThrustValue.AutoSize = true;
            this.lbl_ThrustValue.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lbl_ThrustValue.Location = new System.Drawing.Point(955, 11);
            this.lbl_ThrustValue.Name = "lbl_AktSchub";
            this.lbl_ThrustValue.Size = new System.Drawing.Size(23, 26);
            this.lbl_ThrustValue.TabIndex = 0;
            this.lbl_ThrustValue.Text = "0";
            // 
            // lbl_AnzSchub
            // 
            this.lbl_ThrustLabel.AutoSize = true;
            this.lbl_ThrustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_ThrustLabel.Location = new System.Drawing.Point(928, 10);
            this.lbl_ThrustLabel.Name = "lbl_AnzSchub";
            this.lbl_ThrustLabel.Size = new System.Drawing.Size(32, 26);
            this.lbl_ThrustLabel.TabIndex = 0;
            this.lbl_ThrustLabel.Text = "a:";
            // 
            // lbl_AktTank
            // 
            this.lbl_TankValue.AutoSize = true;
            this.lbl_TankValue.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lbl_TankValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TankValue.Location = new System.Drawing.Point(723, 8);
            this.lbl_TankValue.Name = "lbl_AktTank";
            this.lbl_TankValue.Size = new System.Drawing.Size(23, 26);
            this.lbl_TankValue.TabIndex = 24;
            this.lbl_TankValue.Text = "0";
            // 
            // pictureBox1
            // 
            this.TankLabel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.TankLabel.Location = new System.Drawing.Point(686, 8);
            this.TankLabel.Name = "pictureBox1";
            this.TankLabel.Size = new System.Drawing.Size(38, 28);
            this.TankLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TankLabel.TabIndex = 25;
            this.TankLabel.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 697);
            this.Controls.Add(this.TankLabel);
            this.Controls.Add(this.lbl_TankValue);
            this.Controls.Add(this.lbl_ThrustLabel);
            this.Controls.Add(this.lbl_ThrustValue);
            this.Controls.Add(this.lbl_HeightValue);
            this.Controls.Add(this.lbl_HeightLabel);
            this.Controls.Add(this.lbl_SpeedLabel);
            this.Controls.Add(this.pnl_Animation);
            this.Controls.Add(this.lbl_SpeedValue);
            this.Controls.Add(this.gb_SimulationResults);
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
            this.gb_SimulationResults.ResumeLayout(false);
            this.gb_SimulationResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TankLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_Menue;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_Simulation;
        private System.Windows.Forms.Label lbl_Selector;
        private System.Windows.Forms.ComboBox cmb_Selector;
        private System.Windows.Forms.Label lbl_ChromosomeLength;
        private System.Windows.Forms.TextBox txt_ChromosomeLength;
        private System.Windows.Forms.Label lbl_Recombinator;
        private System.Windows.Forms.ComboBox cmb_Recombinator;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Engine;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Engine;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.GroupBox gb_Population;
        private System.Windows.Forms.DataGridView dgv_Population;
        private System.Windows.Forms.TextBox txt_RoundNumber;
        private System.Windows.Forms.Button btn_Simulate;
        private System.Windows.Forms.Label lbl_RoundNumber;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGene;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFitness;
        private System.Windows.Forms.GroupBox gb_SimulationResults;
        private ZedGraph.ZedGraphControl zgc_Simulationsgraph;
        private System.Windows.Forms.CheckBox chk_AVGFitness;
        private System.Windows.Forms.CheckBox chk_Length;
        private System.Windows.Forms.CheckBox chk_maxFitness;
        private System.Windows.Forms.CheckBox chk_minFitness;
        private System.Windows.Forms.Label lbl_LossRate;
        private System.Windows.Forms.Label lbl_MutationsRate;
        private System.Windows.Forms.Label lbl_DuplicationsRate;
        private System.Windows.Forms.TextBox txt_LossRate;
        private System.Windows.Forms.TextBox txt_MutationsRate;
        private System.Windows.Forms.TextBox txt_DuplicationsRate;
        private System.Windows.Forms.Panel pnl_Animation;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_AutoSim;
        private System.Windows.Forms.Label lbl_SpeedValue;
        private System.Windows.Forms.Label lbl_SpeedLabel;
        private System.Windows.Forms.Label lbl_HeightLabel;
        private System.Windows.Forms.Label lbl_HeightValue;
        private System.Windows.Forms.Label lbl_ThrustValue;
        private System.Windows.Forms.Label lbl_ThrustLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Fitness;
        private System.Windows.Forms.Button btn_SimAbort;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Settings;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SpacemanHeight;
        private System.Windows.Forms.Label lbl_TankValue;
        private System.Windows.Forms.CheckBox chk_Live;
        private System.Windows.Forms.PictureBox TankLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLaenge;

    }
}