namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Statische Klasse für Beispiel Daten. Wird für <see cref="DataGenerator"/> verwendet.
    /// </summary>
    static public class ExampleData
    {
        /// <summary>
        /// Vornamen
        /// </summary>
        static public string[] Vornamen =
        {
            "Maximilian",
            "Susanne",
            "Benjamin",
            "Anna",
        };

        /// <summary>
        /// Vornamen
        /// </summary>
        static public string[] Nachnamen =
        {
            "Muster",
            "Bauer",
            "Maria",
            "Petrovski"
        };


        static public string[] Sprueche = 
        {
            "Legends never die",
            "My Magic will tear you apart",
            "Heeeeeelp meeeee",
            "Thunderbolt!!!"
        };

        static public string[,] Faehigkeiten =
        {
            { "Fliegen", "Hero fliegt in der Luft" },
            { "Feuerball", "Hero schießt Feuerbälle aus den Händen" },
            { "Eislanze", "Hero zaubert Eislanzen aus dem nichts und wirft sie" },
            { "Donnerblitz", "Hero beschwört einen Donner vom Himmel" },
            { "Unsichbarkeit", "Hero wird unsichtbar" },
            { "Dornenpanzer", "Zugefügter Schaden wird um die Hälfte zurück reflektiert" }

        };

        public const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                    "abcdefghijklmnopqrstuvwxyz" +
                                    "0123456789"; 

    }
}
