namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Hero ist ein Lebewesen (<see cref="Entity"/>), bzw eine ingame Figur/Charakter 
    /// </summary>
    public class Hero : Entity
    {
        #region Properties

        /// <summary>
        /// Name des Helden
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Rasse des Helden (<see cref="RaceType"/>)
        /// </summary>
        public RaceType Race { get; set; }

        /// <summary>
        /// Klasse des Helden (<see cref="ClassType"/>
        /// </summary>
        public ClassType HeroClass { get; set; }

        /// <summary>
        /// Lieblingsspruch des Helden
        /// </summary>
        public string Motto { get; set; }

        /// <summary>
        /// Spezialfähigkeit des Helden
        /// </summary>
        public Ability SpecialAbility { get; set; }

        #endregion

        #region Überschriebene Methoden

        public override string ToString()
        {
            return $"\n\tName = {Name} \n\tRace = {Race} \n\tHeroClass = {HeroClass} \n\tMotto = {Motto} \n\tSpecial Ability = {SpecialAbility}\n" + base.ToString();
        }

        #endregion





    }
}
