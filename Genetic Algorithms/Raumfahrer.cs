using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using GeneticAlgorithms.Example_Classes;

namespace GeneticAlgorithms
{
    /// <summary>
    /// Repräsentiert einen Raumfahrer mit den Eigenschaften Kommandoliste, nächstes Kommando und Gewicht
    /// </summary>
    public class Raumfahrer
    {
        /// <summary>
        /// Die Liste der Steuerbefehle
        /// </summary>
        protected ArrayList kommandoListe;
        /// <summary>
        /// Das nächste auszuführende Kommando
        /// </summary>
        protected int naechstesKommando;

        /// <summary>
        /// Gibt das Gewicht zurück. Das Gewicht eines Raumfahrers entspricht der Chromosomenlänge bzw. der Anzahl an Kommandos
        /// </summary>
        public int Gewicht
        {
            get { return kommandoListe.Count; }
        }

        /// <summary>
        /// Konstruktor, weist dem Raumfahrer eine Kommandoliste zu
        /// </summary>
        /// <param name="kommandoListe">Die zuzuweisende Kommandoliste</param>
        public Raumfahrer(ArrayList kommandoListe)
        {
            if (kommandoListe == null)
                throw new NullReferenceException();
            this.kommandoListe = kommandoListe;
            this.naechstesKommando = 0;
        }

        /// <summary>
        /// Weist dem Raumfahrer ein Raumschiff zu und lässt es ihn steuern.
        /// </summary>
        /// <param name="raumschiff">Das zuzuweisende Raumschiff</param>
        /// <returns>Ausgeführtes Kommando, also Schubkraft</returns>
        public int SteuereRaumschiff(Raumschiff raumschiff)
        {
            int schub = raumschiff.Beschleunigen(kommandoListe[naechstesKommando] as IntGene);
            if (++naechstesKommando == kommandoListe.Count)
                naechstesKommando = 0;
            return schub;
        }
    }
}
