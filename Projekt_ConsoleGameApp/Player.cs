using System;
using System.Collections.Generic;

namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Spieler mit seinen Hero's (<see cref="Hero"/>)
    /// </summary>
    public class Player : IEquatable<Player>
    {
        #region Properties

        /// <summary>
        /// Liste von Helden (<see cref="Hero"/>)
        /// </summary>
        public List<Hero> Heroes { get; set; }

        /// <summary>
        /// Username des Spielers, wird fürs Anmelden benötigt
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Passwort des Spielers, wird fürs Anmelden benötigt
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Name des Spielers Ingame
        /// </summary>
        public string InGameName { get; set; }

        /// <summary>
        /// Ingame Geld des Spielers
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// Spielzeit des Spielers in Stunden
        /// </summary>
        public int PlayedTime { get; set; }

        #endregion

        #region Methoden

        /// <summary>
        /// Überschreibt die Equals Methode um Spieler (<see cref="Player"/>) vergleichen zu können
        /// <para /> Geprüft wird über den gleichen InGameNamen & UserName
        /// </summary>
        /// <param name="other">Anderer Spieler</param>
        /// <returns>true wenns der gleiche ist</returns>
        public bool Equals(Player other)
        {
            if (other == null)
                return false;

            return InGameName.Equals(other.InGameName) && Username.Equals(other.Username);
        }
        
        #endregion

    }
}
