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

namespace GeneticAlgorithms
{
    /* IChromosome
     * 
     * IChromosome muss von allen Chromosomklassen implementiert werden.
     * - IChromosome.Fitness liefert die Fitness des Chromosoms zurück
     * - IChromosome.DuplicateGene dupliziert das Gen an der durch index bestimmten Position im Chromosom
     * - IChromosome.DropGene entfernt das Gen an der durch index bestimmten Position im Chromosom
     */
    public interface IChromosome
    {
        float Fitness
        {
            get;
        }
        void DuplicateGene(int index);
        void DropGene(int index);
    }
}
