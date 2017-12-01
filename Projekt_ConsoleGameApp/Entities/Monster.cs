namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Monster ist ein Lebewesen (<see cref="Entity"/>), natürliche Feinde der Helden
    /// </summary>
    public class Monster : Entity
    {
        #region Properties

        /// <summary>
        /// Rasse des Monsters (<see cref="MonsterType"/>)
        /// </summary>
        public MonsterType MonsterRace { get; set; }

        /// <summary>
        /// Seltenheit des Monsters (<see cref="Rarity"/>)
        /// </summary>
        public Rarity MonsterRarity { get; set; }

        #endregion

        #region Überschriebene Methoden

        public override string ToString()
        {
            return base.ToString() + $", Monster Race = {MonsterRace}, Rarity = {MonsterRarity}";
        }

        #endregion

    }
}
