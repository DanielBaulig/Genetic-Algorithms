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
    /* generic class Chromosome<Gene>
     *  implementiert: IChromosome, IComparable<Chromosome<Gene>>
     *  Gene implementiert: IGene, einen Konstruktor
     * 
     * Chromosome<Gene> ist eine allgemeine (generische) Chromosomklasse. Sieht implementiert das
     * Chromosome-Interface und das Sortier-Interface IComparable.
     * Die Klasse beherbergt einen Strang von Genen und erlaubt es mit diesen durch Methoden zu 
     * interagieren.
     */
    public class Chromosome<Gene>: IChromosome, IComparable<Chromosome<Gene>> where Gene: IGene, new()
    {
        // Liste von Genen; es wird davon ausgegangen, dass hier nur Objekte vom Typ Gene abgelegt werden.
        protected ArrayList genes;
        // Die Fitness des Chromosoms wird hier gespeichert
        private float fitness;

        // Zugriffs Property auf die Fitness des Chromosoms
        public float Fitness
        {
            get
            {
                return this.fitness;
            }
        }

        // Dupliziert ein Gen an der durch index bestimmten Position
        public void DuplicateGene(int index)
        {
            Gene gene = new Gene();
            gene = (Gene) this[index].Clone();
            this.genes.Insert(index, gene);
        }

        // Entfernt ein Gen an der durch index bestimmten Position
        public void DropGene(int index)
        {
            this.genes.RemoveAt(index);
        }

        // Errechnet mithilfe eines IFitnessFunctionProvider Interface die Fitness des Chromosoms
        public void computeFitness(IFitnessFunctionProvider provider)
        {
            this.fitness = provider.ComputeFitness(this.genes);
        }

        // Geschützter Konstruktor, der ein Chromosom aus einer ArrayList von Gegen erzeugt (für Rekombination erforderlich)
        protected Chromosome(ArrayList genes)
        {
            if (genes.Count > 0)
                if (genes[genes.Count - 1].GetType() == typeof(Gene))
                    this.genes = new ArrayList(genes);
                else
                    throw new ArrayTypeMismatchException();
            else
                this.genes = new ArrayList();
        }

        // Konstruktor, der ein Chromosom mit geneCount zufällig initialisierten Genen erzeugt
        public Chromosome(int geneCount)
        {
            this.genes = new ArrayList(geneCount);
            while (this.genes.Count < geneCount)
                this.genes.Add(new Gene());
        }

        // Rekombiniert dieses Chromosom mit einem durch partner spezifizierten anderen Chromosom
        // Das IRecombinatorProvider Interface recombinator stellt dafür die Methode zur Verfügung.
        public Chromosome<Gene> Recombine(Chromosome<Gene> partner, IRecombinationProvider recombinator)
        {
            return new Chromosome<Gene>(recombinator.Recombine(this.genes, partner.genes));
        }

        // Array-Zugriffs-Property für die Gen-Liste
        public Gene this[int index]
        {
            get
            {
                return (Gene) genes[index];
            }
            set
            {
                genes[index] = value;
            }
        }

        // Zugriffs-Property für die Chromosom-Länge
        public int GeneCount
        {
            get
            {
                return this.genes.Count; 
            }
        }

        // Wandelt das Chromosom in eine menschen-lesbare Form um
        override public string ToString()
        {
            string resultString = "";
            foreach (Gene gene in genes)
            {
                resultString += gene.ToString();
            }
            return resultString;
        }

        #region IComparable<Chromosome<Gene>> Member

        // Implementation des IComparable Interfaces zum sortieren von Chromosomen.
        public int CompareTo(Chromosome<Gene> other)
        {
            return this.fitness.CompareTo(other.fitness);
        }

        #endregion
    }
}
