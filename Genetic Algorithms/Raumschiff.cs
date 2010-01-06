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
        private Raumfahrer pilot;


        /*
        *  Konstruktor
        */
        public Raumschiff(Raumfahrer pilot, int startHoehe, int startTreibstoff, int startGewicht)
        {
            this.pilot = pilot;
            this.hoehe = startHoehe;
            this.treibstoff = startTreibstoff;
            this.gewicht = startGewicht;
        }

        /*
         *  treibstoff, gewicht und geschwindigkeit wird verändert.
         */
        public void Beschleunigen(int schub)
        {
            if (hoehe > 0)
            {
                if (treibstoff > 0)
                {
                    if (treibstoff >= schub)
                    {
                        this.gewicht -= schub;
                        this.geschwindigkeit += schub;
                        this.treibstoff -= schub;
                    }
                    else
                    {
                        this.gewicht -= treibstoff;
                        this.geschwindigkeit += treibstoff;
                        this.treibstoff = 0;
                    }
                }
                else
                {
                    System.Console.WriteLine("Objekt kann keinen Schub mehr geben.");
                }

            }
            else
            {
                /*
                 *  ToDo Objekt ist gelandet/zerschellt.
                 */
                System.Console.WriteLine("Objekt ist gelandet/zerschellt");
            }
        }

        public void SimuliereRunde()
        {
            int tmpGewicht = 0;

            tmpGewicht = gewicht + treibstoff + pilot.Gewicht;
            geschwindigkeit -= tmpGewicht;
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
