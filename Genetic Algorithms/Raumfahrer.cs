using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using GeneticAlgorithms.Example_Classes;

namespace GeneticAlgorithms
{
    public class Raumfahrer
    {
        protected ArrayList kommandoListe;
        protected int naechstesKommando;

        public int Gewicht
        {
            get { return kommandoListe.Count; }
        }

        public Raumfahrer(ArrayList kommandoListe)
        {
            if (kommandoListe == null)
                throw new NullReferenceException();
            this.kommandoListe = kommandoListe;
            this.naechstesKommando = 0;
        }

        public int SteuereRaumschiff(Raumschiff raumschiff)
        {
            int schub = raumschiff.Beschleunigen(kommandoListe[naechstesKommando] as IntGene);
            if (++naechstesKommando == kommandoListe.Count)
                naechstesKommando = 0;
            return schub;
        }
    }
}
