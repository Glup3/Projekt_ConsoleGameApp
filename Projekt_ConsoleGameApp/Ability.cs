namespace Projekt_ConsoleGameApp
{
    public class Ability
    {
        #region Properties

        /// <summary>
        /// Fähigkeitenname
        /// </summary>
        public string AbilityName { get; set; }

        /// <summary>
        /// Beschreibung der Fähigkeit
        /// </summary>
        public string AbilityDescription { get; set; }

        #endregion

        #region Überschriebene Methoden 

        /// <summary>
        /// Muster: 
        /// </summary>
        /// <returns>Name und Beschreibung der Ability</returns>
        public override string ToString()
        {
            return $"{AbilityName}: {AbilityDescription}";
        }

        #endregion
    }
}
