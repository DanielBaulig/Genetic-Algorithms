using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithms.Example_Classes;

namespace GeneticAlgorithms
{
    public class MondlandungsSimulationEventArgs : EventArgs
    {
        private Raumschiff raumschiff;
        private int schub;

        public int Schub
        {
            get
            {
                return schub;
            }
        }

        public Raumschiff Raumschiff
        {
            get
            {
                return this.raumschiff;
            }
        }

        public MondlandungsSimulationEventArgs(Raumschiff raumschiff, int schub)
        {
            this.raumschiff = raumschiff;
            this.schub = schub;
        }
    }

    public class MondlandungsSimulation : IFitnessFunctionProvider
    {
        private int startHoehe;
        private int startTreibstoff;
        private int raumschiffGewicht;
        private bool nutzeRaumfahrerGewicht;

        public OnSimulationTurn SimulationTurn;

        public MondlandungsSimulation(int raumschiffStartHoehe, int raumschiffStartTreibstoff, int raumschiffStartGewicht, bool nutzeRaumfahrerGewicht)
        {
            startHoehe = raumschiffStartHoehe;
            startTreibstoff = raumschiffStartTreibstoff;
            raumschiffGewicht = raumschiffStartGewicht;
            this.nutzeRaumfahrerGewicht = nutzeRaumfahrerGewicht;
        }

        #region IFitnessFunctionProvider Member

        public float ComputeFitness(ArrayList genes)
        {
            float fitness = 0.0f;
            Raumfahrer pilot = new Raumfahrer(genes);
            Raumschiff raumschiff = new Raumschiff(pilot, startHoehe, startTreibstoff, raumschiffGewicht, nutzeRaumfahrerGewicht);
            int schub = 0;
            while (raumschiff.Hoehe > 0)
            {
                schub = pilot.SteuereRaumschiff(raumschiff);
                raumschiff.SimuliereRunde();
                if (SimulationTurn != null)
                    SimulationTurn(this, new MondlandungsSimulationEventArgs(raumschiff, schub));
            }
            /*if (SimulationTurn != null)
                SimulationTurn(this, new MondlandungsSimulationEventArgs(raumschiff, schub));*/
            // Convert.ToInt32(Math.Sqrt((raumschiff.Hoehe * raumschiff.Hoehe))) +  
            /*int toleranz = Convert.ToInt32(Math.Sqrt((raumschiff.Geschwindigkeit * raumschiff.Geschwindigkeit))) - 5;
            if (toleranz < 0)
                toleranz = 0;*/

            //fitness = ((1000 + raumschiff.Geschwindigkeit) / 1000.0f * 0.9f) + (raumschiff.Treibstoff / (float) startTreibstoff * 0.1f);
            //fitness = 0.7f / (1.0f + toleranz/10) + (raumschiff.Treibstoff / (float)startTreibstoff * 0.3f);
            //fitness = 0.6f * Convert.ToInt32(Math.Pow(1.01, -toleranz)) + (raumschiff.Treibstoff / (float)startTreibstoff * 0.4f);
            fitness = 0.7f * Convert.ToSingle(Math.Pow(1.02f, raumschiff.Geschwindigkeit)) + (raumschiff.Treibstoff / (float)startTreibstoff * 0.3f);
            //fitness = 1 / (1.0f - raumschiff.Geschwindigkeit/10.0f);

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
