using System.Collections.Generic;

namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Klasse Game beinhaltet die Spieler und Monster
    /// </summary>
    public class Game
    {
        #region Properties

        /// <summary>
        /// Name des Spiels (<see cref="Game"/>)
        /// </summary>
        public string GameName { get; set; }

        /// <summary>
        /// Liste von Spielern (<see cref="PlayerList"/>, <see cref="Player"/>)
        /// </summary>
        public PlayerList PlayerListe { get; set; }

        /// <summary>
        /// Liste von Monstern (<see cref="Monster"/>)
        /// </summary>
        public List<Monster> MonsterListe { get; set; }




        #endregion


    }
}
