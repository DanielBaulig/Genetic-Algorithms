using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithms.Example_Classes.MondLandungs
{
    /// <summary>
    /// Repräsentiert ein Raumschiff mit den Eigenschaften Treibstoff, Gewicht, Geschwindigkeit, Höhe und einem Raumfahrer
    /// </summary>
    public class Raumschiff
    {
        private int treibstoff;
        private int gewicht;
        private int geschwindigkeit;
        private int hoehe;
        private bool nutzeRaumfahrerGewicht;
        private Raumfahrer pilot;


        /// <summary>
        /// Konstruktor des Raumschiffs
        /// </summary>
        /// <param name="pilot">Pilot, der das Raumschiff steuern soll</param>
        /// <param name="startHoehe">Die Starthöhe des Raumschiffs</param>
        /// <param name="startTreibstoff">Der Starttreibstoff des Raumschiffs</param>
        /// <param name="startGewicht">Das Startgewicht des Raumschiffs</param>
        /// <param name="nutzeRaumfahrerGewicht">Gibt an, ob das Gewicht des Raumfahrers mit einberechnet werden soll</param>
        public Raumschiff(Raumfahrer pilot, int startHoehe, int startTreibstoff, int startGewicht, bool nutzeRaumfahrerGewicht)
        {
            this.pilot = pilot;
            this.hoehe = startHoehe;
            this.treibstoff = startTreibstoff;
            this.gewicht = startGewicht;
            this.geschwindigkeit = 0;
            this.nutzeRaumfahrerGewicht = nutzeRaumfahrerGewicht;
        }

        /// <summary>
        /// Beschleunigt das Raumschiff, wenn genügend Treibstoff übrig ist und berechnet anschließend die neuen Werte für Geschwindigkeit und Treibstoff
        /// </summary>
        /// <param name="schub">Anzahl der zu gebenden Schubs</param>
        /// <returns>Tatsächlich gegegebener Schub</returns>
        public int Beschleunigen(int schub)
        {
            if (treibstoff > 0)
            {
                if (treibstoff >= schub)
                {
                    this.geschwindigkeit += schub;
                    this.treibstoff -= schub;
                    return schub;
                }
                else
                {
                    this.geschwindigkeit += treibstoff;
                    int tmpTreibstoff = this.treibstoff;
                    this.treibstoff = 0;
                    return tmpTreibstoff;
                }
            }
            else
                return 0;
        }

        /// <summary>
        /// Simuliert eine Runde, berechnet die neue Höhe und Geschwindigkeit
        /// </summary>
        public void SimuliereRunde()
        {
            geschwindigkeit -= gewicht;
            if (nutzeRaumfahrerGewicht)
                geschwindigkeit -= pilot.Gewicht;
            hoehe += geschwindigkeit;
        }


        public int Treibstoff
        {
            get { return treibstoff; }
        }

        public int Gewicht
        {
            get { return gewicht; }
        }

        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
        }

        public int Hoehe
        {
            get { return hoehe; }
        }
    }
}
