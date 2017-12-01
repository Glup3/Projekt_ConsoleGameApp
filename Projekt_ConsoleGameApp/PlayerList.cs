﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Liste von Spielern (<see cref="Player"/>) mit modifizierten Methoden, Jeder Spieler ist einzigartig
    /// </summary>
    public class PlayerList
    {
        #region Variablen

        /// <summary>
        /// Liste der Spieler
        /// </summary>
        private List<Player> liste = new List<Player>();

        #endregion

        #region Methoden

        /// <summary>
        /// Fügt einen Spieler in die Collection hinzu, wenn er noch nicht drinnen ist
        /// </summary>
        /// <param name="player">Neuer Spieler</param>
        /// <returns>true wenn Spieler noch nicht in der Liste ist</returns>
        public bool Add_Player(Player player)
        {
            if(player != null && !liste.Contains(player))
            {
                liste.Add(player);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Entfernt einen Spieler (<see cref="Player"/>) aus der Liste wenn er vorhanden ist
        /// </summary>
        /// <param name="player">Zu entfernender Spieler</param>
        /// <returns>true wenn der Spieler in der Liste ist</returns>
        public bool Remove_Player(Player player)
        {
            return liste.Remove(player);
        }

        public List<Player> Get_All_Players()
        {
            return liste;
        }

        #endregion
    }
}