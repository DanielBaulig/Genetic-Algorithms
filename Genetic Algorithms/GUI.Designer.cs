namespace GeneticAlgorithms
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
            this.txt_Gewicht = new System.Windows.Forms.TextBox();
            this.txt_Treibstoff = new System.Windows.Forms.TextBox();
            this.txt_Hoehe = new System.Windows.Forms.TextBox();
            this.txt_Geschwindigkeit = new System.Windows.Forms.TextBox();
            this.lbl_Gewicht = new System.Windows.Forms.Label();
            this.lbl_Treibstoff = new System.Windows.Forms.Label();
            this.lbl_Hoehe = new System.Windows.Forms.Label();
            this.lbl_Geschwindigkeit = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_Recombination = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Gewicht
            // 
            this.txt_Gewicht.Location = new System.Drawing.Point(126, 51);
            this.txt_Gewicht.Name = "txt_Gewicht";
            this.txt_Gewicht.Size = new System.Drawing.Size(100, 20);
            this.txt_Gewicht.TabIndex = 0;
            // 
            // txt_Treibstoff
            // 
            this.txt_Treibstoff.Location = new System.Drawing.Point(126, 77);
            this.txt_Treibstoff.Name = "txt_Treibstoff";
            this.txt_Treibstoff.Size = new System.Drawing.Size(100, 20);
            this.txt_Treibstoff.TabIndex = 1;
            // 
            // txt_Hoehe
            // 
            this.txt_Hoehe.Location = new System.Drawing.Point(126, 103);
            this.txt_Hoehe.Name = "txt_Hoehe";
            this.txt_Hoehe.Size = new System.Drawing.Size(100, 20);
            this.txt_Hoehe.TabIndex = 2;
            // 
            // txt_Geschwindigkeit
            // 
            this.txt_Geschwindigkeit.Location = new System.Drawing.Point(126, 129);
            this.txt_Geschwindigkeit.Name = "txt_Geschwindigkeit";
            this.txt_Geschwindigkeit.Size = new System.Drawing.Size(100, 20);
            this.txt_Geschwindigkeit.TabIndex = 3;
            // 
            // lbl_Gewicht
            // 
            this.lbl_Gewicht.AutoSize = true;
            this.lbl_Gewicht.Location = new System.Drawing.Point(74, 54);
            this.lbl_Gewicht.Name = "lbl_Gewicht";
            this.lbl_Gewicht.Size = new System.Drawing.Size(46, 13);
            this.lbl_Gewicht.TabIndex = 4;
            this.lbl_Gewicht.Text = "Gewicht";
            // 
            // lbl_Treibstoff
            // 
            this.lbl_Treibstoff.AutoSize = true;
            this.lbl_Treibstoff.Location = new System.Drawing.Point(69, 80);
            this.lbl_Treibstoff.Name = "lbl_Treibstoff";
            this.lbl_Treibstoff.Size = new System.Drawing.Size(51, 13);
            this.lbl_Treibstoff.TabIndex = 5;
            this.lbl_Treibstoff.Text = "Treibstoff";
            // 
            // lbl_Hoehe
            // 
            this.lbl_Hoehe.AutoSize = true;
            this.lbl_Hoehe.Location = new System.Drawing.Point(87, 106);
            this.lbl_Hoehe.Name = "lbl_Hoehe";
            this.lbl_Hoehe.Size = new System.Drawing.Size(33, 13);
            this.lbl_Hoehe.TabIndex = 6;
            this.lbl_Hoehe.Text = "Höhe";
            // 
            // lbl_Geschwindigkeit
            // 
            this.lbl_Geschwindigkeit.AutoSize = true;
            this.lbl_Geschwindigkeit.Location = new System.Drawing.Point(35, 132);
            this.lbl_Geschwindigkeit.Name = "lbl_Geschwindigkeit";
            this.lbl_Geschwindigkeit.Size = new System.Drawing.Size(85, 13);
            this.lbl_Geschwindigkeit.TabIndex = 7;
            this.lbl_Geschwindigkeit.Text = "Geschwindigkeit";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(43, 214);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Asymetric Zip",
            "Crossover",
            "Asymetric Crossover"});
            this.comboBox1.Location = new System.Drawing.Point(126, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // lbl_Recombination
            // 
            this.lbl_Recombination.AutoSize = true;
            this.lbl_Recombination.Location = new System.Drawing.Point(42, 158);
            this.lbl_Recombination.Name = "lbl_Recombination";
            this.lbl_Recombination.Size = new System.Drawing.Size(78, 13);
            this.lbl_Recombination.TabIndex = 11;
            this.lbl_Recombination.Text = "Recombination";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chromosomlänge";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Recombination);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Geschwindigkeit);
            this.Controls.Add(this.lbl_Hoehe);
            this.Controls.Add(this.lbl_Treibstoff);
            this.Controls.Add(this.lbl_Gewicht);
            this.Controls.Add(this.txt_Geschwindigkeit);
            this.Controls.Add(this.txt_Hoehe);
            this.Controls.Add(this.txt_Treibstoff);
            this.Controls.Add(this.txt_Gewicht);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "Mondlandung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Gewicht;
        private System.Windows.Forms.TextBox txt_Treibstoff;
        private System.Windows.Forms.TextBox txt_Hoehe;
        private System.Windows.Forms.TextBox txt_Geschwindigkeit;
        private System.Windows.Forms.Label lbl_Gewicht;
        private System.Windows.Forms.Label lbl_Treibstoff;
        private System.Windows.Forms.Label lbl_Geschwindigkeit;
        private System.Windows.Forms.Label lbl_Hoehe;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Recombination;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

    }
}