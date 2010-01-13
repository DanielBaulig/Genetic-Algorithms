using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithms
{
    class MondlandungsSimulation
    {
        private int startHoehe;
        private int startTreibstoff;
        private int raumschiffGewicht;

        public MondlandungsSimulation(int raumschiffStartHoehe, int raumschiffStartTreibstoff, int raumschiffStartGewicht)
        {
            startHoehe = raumschiffStartHoehe;
            startTreibstoff = raumschiffStartTreibstoff;
            raumschiffGewicht = raumschiffStartGewicht;
            
        }

        public float ComputeFitness(ArrayList genes)
        {
            float fitness = 0.0f;
            Raumfahrer pilot = new Raumfahrer(genes);
            Raumschiff raumschiff = new Raumschiff(pilot, startHoehe, startTreibstoff, raumschiffGewicht);
            pilot.SteuereRaumschiff(raumschiff);
            while (raumschiff.Hoehe > 0)
            {
                raumschiff.SimuliereRunde();
            }

            fitness = ((1000 - raumschiff.Geschwindigkeit) / 1000 * 0.9f) + (raumschiff.Treibstoff / startTreibstoff * 0.1f);
            return fitness;
        }
    }
}
