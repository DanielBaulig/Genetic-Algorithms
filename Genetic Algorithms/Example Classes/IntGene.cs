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

namespace GeneticAlgorithms.Example_Classes
{
    public class IntGene :
        IGene
    {
        public static int MaxValue = 100;
        private static Random randomizer = null;
        protected int value;

        public IntGene(int value)
        {
            if (IntGene.randomizer == null)
                IntGene.randomizer = new Random();
            this.value = value;
        }

        public IntGene()
        {
            if (IntGene.randomizer == null)
                IntGene.randomizer = new Random();
            this.Mutate();
        }

        public override string ToString()
        {
            return value.ToString();
        }
    
        #region IGene Member

        public void Mutate()
        {
            this.value = randomizer.Next() % IntGene.MaxValue;
        }

        #endregion

        public static implicit operator IntGene(int other)
        {
            return new IntGene(other);
        }

        public static implicit operator int(IntGene other)
        {
            return other.value;
        }

        public object Clone()
        {
            return new IntGene(this.value);
        }

        new public bool Equals(object o)
        {
            return (o as IntGene).value == this.value;
        }
    }

}
