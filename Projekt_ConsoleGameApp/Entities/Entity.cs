namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Abstrakte Mutterklasse für Entities (Lebewesen)
    /// </summary>
    public abstract class Entity
    {
        #region Properties

        /// <summary>
        /// Leben des Lebewesens
        /// </summary>
        public double HP { get; set; }

        /// <summary>
        /// Angriffsschaden des Lebewesens
        /// </summary>
        public double AttackDamage { get; set; }

        /// <summary>
        /// Erfahrungspunkte des Lebewesens
        /// </summary>
        public int ExperiencePoints { get; set; }

        /// <summary>
        /// Level des Lebewesens
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Rüstung des Lebewesens
        /// </summary>
        public double Armor { get; set; }

        /// <summary>
        /// Alter des Lebewesens
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Bewegungsgewschindigkeit des Lebewesens
        /// </summary>
        public int MovementSpeed { get; set; }

        #endregion

        #region Überschriebene Methoden

        public override string ToString()
        {
            return $"\tHealthpoints = {HP}, \n\tAttackdamage = {AttackDamage}, \n\tArmor = {Armor}, \n\tLevel = {Level}, \n\tXP = {ExperiencePoints}, \n\tMovementSpeed = {MovementSpeed}, \n\tAge = {Age}";
        }

        #endregion


    }
}
