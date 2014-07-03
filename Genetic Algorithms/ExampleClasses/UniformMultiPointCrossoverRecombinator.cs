using System;
using System.Collections;

namespace GeneticAlgorithms.Example_Classes
{
    public class UniformMultiPointCrossoverRecombinator : IRecombinationProvider
    {
        public static float GenesPerCrossover = 5;

        Random random = new Random();
        #region IRecombinationProvider Member

        public ArrayList Recombine(ArrayList maleGenes, ArrayList femaleGenes)
        {
            ArrayList Child = maleGenes.Clone() as ArrayList;

            bool usingMale = true;
            for (int i = 0; i < maleGenes.Count; i++)
            {
                Child[i] = usingMale ? ((IGene)maleGenes[i]).Clone() : Child[i] = ((IGene)femaleGenes[i]).Clone();
                if (i % GenesPerCrossover == 0) usingMale = !usingMale;
            }

            return Child;
        }

        #endregion
    }
}
