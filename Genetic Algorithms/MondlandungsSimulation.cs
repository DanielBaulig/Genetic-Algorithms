using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithms.Example_Classes;

namespace GeneticAlgorithms
{
    public class MondlandungsSimulation : IFitnessFunctionProvider
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

        #region IFitnessFunctionProvider Member

        public float ComputeFitness(ArrayList genes)
        {
            float fitness = 0.0f;
            Raumfahrer pilot = new Raumfahrer(genes);
            Raumschiff raumschiff = new Raumschiff(pilot, startHoehe, startTreibstoff, raumschiffGewicht);
            while (raumschiff.Hoehe > 0)
            {
               pilot.SteuereRaumschiff(raumschiff); 
               raumschiff.SimuliereRunde();
            }

            fitness = ((1000 + raumschiff.Geschwindigkeit) / 1000.0f * 0.9f) + (raumschiff.Treibstoff / (float) startTreibstoff * 0.1f);

            return fitness;


        }

        // Methode nur für Unit Tests
        public float TestComputeFitness(ArrayList genes)
        {
            float fitness = 0.0f;
            Raumfahrer pilot = new Raumfahrer(genes);

            foreach (IntGene gene in genes)
            {
                fitness += gene;
            }
            return fitness;
        }

        #endregion
    }
}
