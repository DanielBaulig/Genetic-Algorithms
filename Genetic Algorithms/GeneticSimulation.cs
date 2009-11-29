/*  Copyright (c) 2009 Daniel Baulig
 *
 *  This file is part of the Genetic Algorithms library.
 *
 *  The Genetic Algorithms library is free software: you can redistribute 
 *  it and/or modify it under the terms of the GNU General Public License 
 *  as published by the Free Software Foundation, either version 3 of the 
 *  License, or (at your option) any later version.
 *
 *  The Genetic Algorithms library is distributed in the hope that it will 
 *  be useful, but WITHOUT ANY WARRANTY; without even the implied warranty 
 *  of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with the Genetic Algorithms library.  If not, see 
 *  <http://www.gnu.org/licenses/>.
 * 
 *  e-mail: daniel dot baulig at gmx dot de
 *  
 *  If you wish to donate, please have a look at my Amazon Wishlist:
 *  http://www.amazon.de/wishlist/1GWSB78PYVFBQ
 */
using System;
using System.Collections;


namespace GeneticAlgorithms
{
    public delegate void OnSimulationTurn(object sender, EventArgs e);

    public class GeneticSimulation<Gene> where Gene: IGene, new()
    {
        private IFitnessFunctionProvider fitnessComputer;
        private IRecombinationProvider recombinator;
        private ISelectionProvider maleSelector;
        private ISelectionProvider femaleSelector;
        private double geneMutationRate;
        private double geneDropRate;
        private double geneDuplicationRate;
        private float totalFitness;
        private float averageChromosomeLength;
        private int populationSize;
        private int defaultChromosomeLength;
        private Chromosome<Gene> mostSuccessfullIndividual;
        private Chromosome<Gene> leastSuccessfullIndividual;
        protected Random randomizer;

        protected ArrayList population;

        protected Chromosome<Gene> selectMaleChromosome()
        {
            return this.maleSelector.select(this.population, this.totalFitness) as Chromosome<Gene>;
        }

        protected Chromosome<Gene> selectFemaleChromosome()
        {
            return this.femaleSelector.select(this.population, this.totalFitness) as Chromosome<Gene>;
        }

        public Chromosome<Gene> this[int index]
        {
            get
            {
                return this.population[index] as Chromosome<Gene>;
            }
        }

        public int PoppulationSize
        {
            get
            {
                return this.populationSize;
            }
        }

        public int DefaultGeneCount
        {
            get
            {
                return this.defaultChromosomeLength;
            }
        }

        public GeneticSimulation(int populationSize, int defaultGeneCount,IFitnessFunctionProvider fitnessComputer, IRecombinationProvider recombinator, ISelectionProvider selector):
            this(populationSize, defaultGeneCount, fitnessComputer, recombinator, selector, selector)
        {            
        }

        public GeneticSimulation(int populationSize, int defaultGeneCount, IFitnessFunctionProvider fitnessComputer, IRecombinationProvider recombinator, ISelectionProvider maleSelector, ISelectionProvider femaleSelector)
        {
            this.fitnessComputer = fitnessComputer;
            this.recombinator = recombinator;
            this.maleSelector = maleSelector;
            this.femaleSelector = femaleSelector;
            this.populationSize = populationSize;
            this.defaultChromosomeLength = defaultGeneCount;

            this.geneMutationRate = 0.01d;
            this.geneDuplicationRate = 0.0d;
            this.geneDropRate = 0.0d;

            this.randomizer = new Random();

            this.ResetSimulation();
        }

        public float AverageChromosomeLength
        {
            get
            {
                return this.averageChromosomeLength;
            }
        }

        public Chromosome<Gene> MostSuccessfullIndividual
        {
            get
            {
                return mostSuccessfullIndividual;
            }
        }

        public Chromosome<Gene> LeasSuccessfullIndividual
        {
            get 
            {
                return leastSuccessfullIndividual;
            }
        }

        public float TotalFitness
        {
            get
            {
                return totalFitness;
            }
        }

        public float AverageFitness
        {
            get
            {
                return totalFitness / population.Count;
            }
        }

        public double GeneMutationRate
        {
            get { return geneMutationRate; }
            set { geneMutationRate = value; }
        }

        public double GeneDuplicationRate
        {
            get { return geneDuplicationRate; }
            set { geneDuplicationRate = value; }
        }

        public double GeneDropRate
        {
            get { return geneDropRate; }
            set { geneDropRate = value; }
        }

        public IFitnessFunctionProvider FitnessComputer
        {
            get 
            { 
                return fitnessComputer; 
            }
            set
            {
                fitnessComputer = value;
            }
        }

        public IRecombinationProvider Recombinator
        {
            get 
            { 
                return recombinator; 
            }
            set
            {
                recombinator = value;
            }
        }

        public OnSimulationTurn SimulationTurn;

        virtual public void ResetSimulation()
        {
            population = new ArrayList(this.populationSize);
            while (this.population.Count < this.populationSize)
            {
                Chromosome<Gene> chromosome = new Chromosome<Gene>(this.defaultChromosomeLength);
                chromosome.computeFitness(this.fitnessComputer);
                this.population.Add(chromosome);
            }
            populateStatistics();
        }

        virtual protected void populateStatistics()
        {
            this.totalFitness = 0;
            this.averageChromosomeLength = 0;
            this.leastSuccessfullIndividual = null;
            this.mostSuccessfullIndividual = null;
            foreach (Chromosome<Gene> chromosome in this.population)
            {
                if (this.leastSuccessfullIndividual == null || leastSuccessfullIndividual.Fitness > chromosome.Fitness)
                    this.leastSuccessfullIndividual = chromosome;
                if (this.mostSuccessfullIndividual == null || mostSuccessfullIndividual.Fitness < chromosome.Fitness)
                    this.mostSuccessfullIndividual = chromosome;
                totalFitness += chromosome.Fitness;
                averageChromosomeLength += chromosome.GeneCount;
            }
            this.averageChromosomeLength /= this.population.Count;
        }

        virtual public void RunSimulation()
        {
            ArrayList newPopulation = new ArrayList(populationSize);
            Chromosome<Gene> newChromosome = null;
            while (newPopulation.Count < this.populationSize)
            {
                try
                {
                    newChromosome = this.selectMaleChromosome().Recombine(this.selectFemaleChromosome(), this.recombinator);
                    for (int i = 0; i < newChromosome.GeneCount; i++)
                    {
                        if (this.randomizer.NextDouble() < this.geneMutationRate)
                            newChromosome[i].Mutate();
                        if (this.randomizer.NextDouble() < this.geneDuplicationRate)
                            newChromosome.DuplicateGene(i);
                        if (this.randomizer.NextDouble() < this.geneDropRate)
                            newChromosome.DropGene(i);
                    }
                    newChromosome.computeFitness(this.fitnessComputer);
                    newPopulation.Add(newChromosome);
                }
                catch (GenesIncompatibleException ignore)
                {
                }
            }
                
            this.population = newPopulation;

            this.populateStatistics();

            if (SimulationTurn != null)
                SimulationTurn(this, EventArgs.Empty);
        }

        public void RunSimulation(int turns)
        {
            for (int i = 0; i < turns; i++)
                this.RunSimulation();
        }
    }
}
