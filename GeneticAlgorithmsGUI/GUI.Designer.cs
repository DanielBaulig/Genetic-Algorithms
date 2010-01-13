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
            this.mnu_Menue = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Simulation = new System.Windows.Forms.GroupBox();
            this.lbl_Selektor = new System.Windows.Forms.Label();
            this.cmb_Selektor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Rekombinator = new System.Windows.Forms.Label();
            this.cmb_Rekombinator = new System.Windows.Forms.ComboBox();
            this.lbl_Hoehe = new System.Windows.Forms.Label();
            this.lbl_Treibstoff = new System.Windows.Forms.Label();
            this.lbl_Gewicht = new System.Windows.Forms.Label();
            this.txt_Hoehe = new System.Windows.Forms.TextBox();
            this.txt_Treibstoff = new System.Windows.Forms.TextBox();
            this.txt_Gewicht = new System.Windows.Forms.TextBox();
            this.gb_Rundeninformationen = new System.Windows.Forms.GroupBox();
            this.dgv_Population = new System.Windows.Forms.DataGridView();
            this.btn_Simuliere = new System.Windows.Forms.Button();
            this.txt_Rundenazahl = new System.Windows.Forms.TextBox();
            this.lbl_Rundenazahl = new System.Windows.Forms.Label();
            this.btn_Zuruecksetzten = new System.Windows.Forms.Button();
            this.cLaenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFitness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Chromosome = new System.Windows.Forms.Label();
            this.gb_Simulationsiverlauf = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zgc_Simulationsgraph = new ZedGraph.ZedGraphControl();
            this.mnu_Menue.SuspendLayout();
            this.gb_Simulation.SuspendLayout();
            this.gb_Rundeninformationen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Population)).BeginInit();
            this.gb_Simulationsiverlauf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu_Menue
            // 
            this.mnu_Menue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.mnu_Menue.Location = new System.Drawing.Point(0, 0);
            this.mnu_Menue.Name = "mnu_Menue";
            this.mnu_Menue.Size = new System.Drawing.Size(937, 24);
            this.mnu_Menue.TabIndex = 9;
            this.mnu_Menue.Text = "mnu_Menue";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
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
            // 
            // gb_Simulation
            // 
            this.gb_Simulation.Controls.Add(this.btn_Zuruecksetzten);
            this.gb_Simulation.Controls.Add(this.lbl_Rundenazahl);
            this.gb_Simulation.Controls.Add(this.txt_Rundenazahl);
            this.gb_Simulation.Controls.Add(this.btn_Simuliere);
            this.gb_Simulation.Controls.Add(this.lbl_Selektor);
            this.gb_Simulation.Controls.Add(this.cmb_Selektor);
            this.gb_Simulation.Controls.Add(this.label1);
            this.gb_Simulation.Controls.Add(this.textBox1);
            this.gb_Simulation.Controls.Add(this.lbl_Rekombinator);
            this.gb_Simulation.Controls.Add(this.cmb_Rekombinator);
            this.gb_Simulation.Controls.Add(this.lbl_Hoehe);
            this.gb_Simulation.Controls.Add(this.lbl_Treibstoff);
            this.gb_Simulation.Controls.Add(this.lbl_Gewicht);
            this.gb_Simulation.Controls.Add(this.txt_Hoehe);
            this.gb_Simulation.Controls.Add(this.txt_Treibstoff);
            this.gb_Simulation.Controls.Add(this.txt_Gewicht);
            this.gb_Simulation.Location = new System.Drawing.Point(12, 36);
            this.gb_Simulation.Name = "gb_Simulation";
            this.gb_Simulation.Size = new System.Drawing.Size(591, 145);
            this.gb_Simulation.TabIndex = 16;
            this.gb_Simulation.TabStop = false;
            this.gb_Simulation.Text = "Simulationsparameter";
            // 
            // lbl_Selektor
            // 
            this.lbl_Selektor.AutoSize = true;
            this.lbl_Selektor.Location = new System.Drawing.Point(226, 25);
            this.lbl_Selektor.Name = "lbl_Selektor";
            this.lbl_Selektor.Size = new System.Drawing.Size(46, 13);
            this.lbl_Selektor.TabIndex = 27;
            this.lbl_Selektor.Text = "Selektor";
            // 
            // cmb_Selektor
            // 
            this.cmb_Selektor.FormattingEnabled = true;
            this.cmb_Selektor.Items.AddRange(new object[] {
            "Asymetric Zip",
            "Crossover",
            "Asymetric Crossover"});
            this.cmb_Selektor.Location = new System.Drawing.Point(278, 21);
            this.cmb_Selektor.Name = "cmb_Selektor";
            this.cmb_Selektor.Size = new System.Drawing.Size(100, 21);
            this.cmb_Selektor.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Chromosomlänge";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // lbl_Rekombinator
            // 
            this.lbl_Rekombinator.AutoSize = true;
            this.lbl_Rekombinator.Location = new System.Drawing.Point(199, 51);
            this.lbl_Rekombinator.Name = "lbl_Rekombinator";
            this.lbl_Rekombinator.Size = new System.Drawing.Size(73, 13);
            this.lbl_Rekombinator.TabIndex = 23;
            this.lbl_Rekombinator.Text = "Rekombinator";
            // 
            // cmb_Rekombinator
            // 
            this.cmb_Rekombinator.FormattingEnabled = true;
            this.cmb_Rekombinator.Items.AddRange(new object[] {
            "Asymetric Zip",
            "Crossover",
            "Asymetric Crossover"});
            this.cmb_Rekombinator.Location = new System.Drawing.Point(278, 48);
            this.cmb_Rekombinator.Name = "cmb_Rekombinator";
            this.cmb_Rekombinator.Size = new System.Drawing.Size(100, 21);
            this.cmb_Rekombinator.TabIndex = 22;
            // 
            // lbl_Hoehe
            // 
            this.lbl_Hoehe.AutoSize = true;
            this.lbl_Hoehe.Location = new System.Drawing.Point(30, 77);
            this.lbl_Hoehe.Name = "lbl_Hoehe";
            this.lbl_Hoehe.Size = new System.Drawing.Size(33, 13);
            this.lbl_Hoehe.TabIndex = 21;
            this.lbl_Hoehe.Text = "Höhe";
            // 
            // lbl_Treibstoff
            // 
            this.lbl_Treibstoff.AutoSize = true;
            this.lbl_Treibstoff.Location = new System.Drawing.Point(12, 51);
            this.lbl_Treibstoff.Name = "lbl_Treibstoff";
            this.lbl_Treibstoff.Size = new System.Drawing.Size(51, 13);
            this.lbl_Treibstoff.TabIndex = 20;
            this.lbl_Treibstoff.Text = "Treibstoff";
            // 
            // lbl_Gewicht
            // 
            this.lbl_Gewicht.AutoSize = true;
            this.lbl_Gewicht.Location = new System.Drawing.Point(17, 25);
            this.lbl_Gewicht.Name = "lbl_Gewicht";
            this.lbl_Gewicht.Size = new System.Drawing.Size(46, 13);
            this.lbl_Gewicht.TabIndex = 19;
            this.lbl_Gewicht.Text = "Gewicht";
            // 
            // txt_Hoehe
            // 
            this.txt_Hoehe.Location = new System.Drawing.Point(69, 74);
            this.txt_Hoehe.Name = "txt_Hoehe";
            this.txt_Hoehe.Size = new System.Drawing.Size(100, 20);
            this.txt_Hoehe.TabIndex = 18;
            // 
            // txt_Treibstoff
            // 
            this.txt_Treibstoff.Location = new System.Drawing.Point(69, 48);
            this.txt_Treibstoff.Name = "txt_Treibstoff";
            this.txt_Treibstoff.Size = new System.Drawing.Size(100, 20);
            this.txt_Treibstoff.TabIndex = 17;
            // 
            // txt_Gewicht
            // 
            this.txt_Gewicht.Location = new System.Drawing.Point(69, 22);
            this.txt_Gewicht.Name = "txt_Gewicht";
            this.txt_Gewicht.Size = new System.Drawing.Size(100, 20);
            this.txt_Gewicht.TabIndex = 16;
            // 
            // gb_Rundeninformationen
            // 
            this.gb_Rundeninformationen.Controls.Add(this.lbl_Chromosome);
            this.gb_Rundeninformationen.Controls.Add(this.dgv_Population);
            this.gb_Rundeninformationen.Location = new System.Drawing.Point(12, 420);
            this.gb_Rundeninformationen.Name = "gb_Rundeninformationen";
            this.gb_Rundeninformationen.Size = new System.Drawing.Size(591, 282);
            this.gb_Rundeninformationen.TabIndex = 17;
            this.gb_Rundeninformationen.TabStop = false;
            this.gb_Rundeninformationen.Text = "Rundeninformationen";
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
            this.dgv_Population.Location = new System.Drawing.Point(6, 83);
            this.dgv_Population.MultiSelect = false;
            this.dgv_Population.Name = "dgv_Population";
            this.dgv_Population.ReadOnly = true;
            this.dgv_Population.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Population.Size = new System.Drawing.Size(579, 193);
            this.dgv_Population.TabIndex = 18;
            // 
            // btn_Simuliere
            // 
            this.btn_Simuliere.Location = new System.Drawing.Point(417, 114);
            this.btn_Simuliere.Name = "btn_Simuliere";
            this.btn_Simuliere.Size = new System.Drawing.Size(75, 23);
            this.btn_Simuliere.TabIndex = 28;
            this.btn_Simuliere.Text = "Simuliere";
            this.btn_Simuliere.UseVisualStyleBackColor = true;
            // 
            // txt_Rundenazahl
            // 
            this.txt_Rundenazahl.Location = new System.Drawing.Point(367, 114);
            this.txt_Rundenazahl.Name = "txt_Rundenazahl";
            this.txt_Rundenazahl.Size = new System.Drawing.Size(44, 20);
            this.txt_Rundenazahl.TabIndex = 29;
            this.txt_Rundenazahl.Text = "1";
            // 
            // lbl_Rundenazahl
            // 
            this.lbl_Rundenazahl.AutoSize = true;
            this.lbl_Rundenazahl.Location = new System.Drawing.Point(291, 117);
            this.lbl_Rundenazahl.Name = "lbl_Rundenazahl";
            this.lbl_Rundenazahl.Size = new System.Drawing.Size(70, 13);
            this.lbl_Rundenazahl.TabIndex = 30;
            this.lbl_Rundenazahl.Text = "Rundenazahl";
            // 
            // btn_Zuruecksetzten
            // 
            this.btn_Zuruecksetzten.Location = new System.Drawing.Point(498, 114);
            this.btn_Zuruecksetzten.Name = "btn_Zuruecksetzten";
            this.btn_Zuruecksetzten.Size = new System.Drawing.Size(86, 23);
            this.btn_Zuruecksetzten.TabIndex = 31;
            this.btn_Zuruecksetzten.Text = "Zurücksetzten";
            this.btn_Zuruecksetzten.UseVisualStyleBackColor = true;
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
            // lbl_Chromosome
            // 
            this.lbl_Chromosome.AutoSize = true;
            this.lbl_Chromosome.Location = new System.Drawing.Point(6, 67);
            this.lbl_Chromosome.Name = "lbl_Chromosome";
            this.lbl_Chromosome.Size = new System.Drawing.Size(68, 13);
            this.lbl_Chromosome.TabIndex = 19;
            this.lbl_Chromosome.Text = "Chromosome";
            this.lbl_Chromosome.Click += new System.EventHandler(this.lbl_Chromosome_Click);
            // 
            // gb_Simulationsiverlauf
            // 
            this.gb_Simulationsiverlauf.Controls.Add(this.zgc_Simulationsgraph);
            this.gb_Simulationsiverlauf.Location = new System.Drawing.Point(12, 187);
            this.gb_Simulationsiverlauf.Name = "gb_Simulationsiverlauf";
            this.gb_Simulationsiverlauf.Size = new System.Drawing.Size(591, 227);
            this.gb_Simulationsiverlauf.TabIndex = 18;
            this.gb_Simulationsiverlauf.TabStop = false;
            this.gb_Simulationsiverlauf.Text = "Simulationsverlauf";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(609, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 666);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // zgc_Simulationsgraph
            // 
            this.zgc_Simulationsgraph.Location = new System.Drawing.Point(6, 19);
            this.zgc_Simulationsgraph.Name = "zgc_Simulationsgraph";
            this.zgc_Simulationsgraph.ScrollGrace = 0;
            this.zgc_Simulationsgraph.ScrollMaxX = 0;
            this.zgc_Simulationsgraph.ScrollMaxY = 0;
            this.zgc_Simulationsgraph.ScrollMaxY2 = 0;
            this.zgc_Simulationsgraph.ScrollMinX = 0;
            this.zgc_Simulationsgraph.ScrollMinY = 0;
            this.zgc_Simulationsgraph.ScrollMinY2 = 0;
            this.zgc_Simulationsgraph.Size = new System.Drawing.Size(578, 202);
            this.zgc_Simulationsgraph.TabIndex = 0;
            this.zgc_Simulationsgraph.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 708);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_Simulationsiverlauf);
            this.Controls.Add(this.gb_Rundeninformationen);
            this.Controls.Add(this.gb_Simulation);
            this.Controls.Add(this.mnu_Menue);
            this.MainMenuStrip = this.mnu_Menue;
            this.Name = "GUI";
            this.Text = "Mondlandung";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.mnu_Menue.ResumeLayout(false);
            this.mnu_Menue.PerformLayout();
            this.gb_Simulation.ResumeLayout(false);
            this.gb_Simulation.PerformLayout();
            this.gb_Rundeninformationen.ResumeLayout(false);
            this.gb_Rundeninformationen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Population)).EndInit();
            this.gb_Simulationsiverlauf.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Rekombinator;
        private System.Windows.Forms.ComboBox cmb_Rekombinator;
        private System.Windows.Forms.Label lbl_Hoehe;
        private System.Windows.Forms.Label lbl_Treibstoff;
        private System.Windows.Forms.Label lbl_Gewicht;
        private System.Windows.Forms.TextBox txt_Hoehe;
        private System.Windows.Forms.TextBox txt_Treibstoff;
        private System.Windows.Forms.TextBox txt_Gewicht;
        private System.Windows.Forms.GroupBox gb_Rundeninformationen;
        private System.Windows.Forms.DataGridView dgv_Population;
        private System.Windows.Forms.TextBox txt_Rundenazahl;
        private System.Windows.Forms.Button btn_Simuliere;
        private System.Windows.Forms.Label lbl_Rundenazahl;
        private System.Windows.Forms.Button btn_Zuruecksetzten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLaenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGene;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFitness;
        private System.Windows.Forms.Label lbl_Chromosome;
        private System.Windows.Forms.GroupBox gb_Simulationsiverlauf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZedGraph.ZedGraphControl zgc_Simulationsgraph;

    }
}