using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithms
{
    public class Raumschiff
    {
        private int treibstoff;
        private int gewicht;
        private int geschwindigkeit;
        private int hoehe;
        private bool nutzeRaumfahrerGewicht;
        private Raumfahrer pilot;


        /*
        *  Konstruktor
        */
        public Raumschiff(Raumfahrer pilot, int startHoehe, int startTreibstoff, int startGewicht, bool nutzeRaumfahrerGewicht)
        {
            this.pilot = pilot;
            this.hoehe = startHoehe;
            this.treibstoff = startTreibstoff;
            this.gewicht = startGewicht;
            this.geschwindigkeit = 0;
            this.nutzeRaumfahrerGewicht = nutzeRaumfahrerGewicht;
        }

        /*
         *  treibstoff, gewicht und geschwindigkeit wird verändert.
         */
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
