using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoquartett
{
    class Player
    {
        /*
         * Eigenes Deck des Spielers.
         */
        private LinkedList<object> cars = new LinkedList<object>();
        /*
         * Anzahl der Bereits gewonnenen Spiele (in MatchRunde)
         */
        private int wins;
        /*
         * Zeigt an, ob sich der Spieler aktiv im Spiel befindet.
         */
        private bool inGame;

        /*
         * Fügt der liste cars ein Objekt der Klasse Car hinzu (Fügt dem Spielstapel cars eine weitere Karte hinzu)
         */
        public void AddCar(object car)
        {
            cars.AddLast(car);
        }

        /*
         * Gibt die Anzahl der Elemente in cars zurück (Gibt die Anzahl der Karten im Deck zurück)
         */
        public int GetCarCount()
        {
            return cars.Count();
        }
        /*
         * Erhöht wins, um 1 (Erhöht den Zähler der gewonnenen Spiele um 1) 
         */
        public void AddWin()
        {
            wins = wins + 1;
        }
        /*
         * Setzt den Wert von inGame auf true oder false
         */
        public void SetInGame(bool inGame)
        {
            this.inGame = inGame;
        }
        /*
         * Entfernt den ersten Eintrag der Liste cars (Entfernt die oberste Karte vom Spielstapel)
         */
        public void RemoveCard()
        {
            cars.Remove(0);
        }

        /*
         * Gibt den ersten Eintrag der der Liste cars zurück (Zeigt die oberte Karte des Spielstapels an)
         */
        public object GetFirstCard()
        {
            return cars.First();
        }

        /*
         * Gibt den Wert von inGame zurück (Prüft, ob sich der Spiel aktiv im Spiel befindet)
         */
        public bool IsInGame()
        {
            return inGame;
        }
    }
}
