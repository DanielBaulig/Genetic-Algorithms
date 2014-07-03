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

namespace GeneticAlgorithms.ExampleClasses
{
    public class BoolGene :
        IGene
    {
        private static Random randomizer = null;
        protected bool value;

        public BoolGene(bool value)
        {
            if (BoolGene.randomizer == null)
                BoolGene.randomizer = new Random();
            this.value = value;
        }

        public BoolGene()
        {
            if (BoolGene.randomizer == null)
                BoolGene.randomizer = new Random();
            this.Mutate();
        }

        public override string ToString()
        {
            if (this.value)
                return "1";
            else
                return "0";
            //return value.ToString();
        }
    
        #region IGene Member

        public void Mutate()
        {
            this.value = !this.value;//Convert.ToBoolean(randomizer.Next(0, 2));
        }

        #endregion

        public static implicit operator BoolGene(bool other)
        {
            return new BoolGene(other);
        }

        public static implicit operator bool(BoolGene other)
        {
            return other.value;
        }

        public object Clone()
        {
            return new BoolGene(this.value);
        }

        new public bool Equals(object o)
        {
            return (o as BoolGene).value == this.value;
        }
    }

}
