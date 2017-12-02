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
            "Benjamin",
            "Jackson",
            "Lucas",
            "Oliver",
            "Sebastian",
            "Jacob",
            "Matthew",
            "Luke",
            "Michael",
            "Julian",

            "Susanne",
            "Anna",
            "Sophia",
            "Emma",
            "Isabella",
            "Zoe",
            "Charlotte",
            "Emily",
            "Hannah",
            "Caitlynn",
            "Victoria"
        };

        /// <summary>
        /// Nachnamen
        /// </summary>
        static public string[] Nachnamen =
        {
            "Smith",
            "Johnson",
            "Williams",
            "Jones",
            "Brown",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor",
            "Anderson",
            "Thomas",
            "Jackson",
            "White",
            "Harris",
            "Martin",
            "Thompson",
            "Garcia",
            "Martinez",
            "Robinson",
            "Clark",
            "Lee",
        };

        /// <summary>
        /// Sprüche (Motto)
        /// </summary>
        static public string[] Sprueche = 
        {
            "Legends never die",
            "My Magic will tear you apart",
            "Heeeeeelp meeeee",
            "Thunderbolt!!!",
            "DEMACIAAAAA",
            "Remember the Alamo",
            "But man is not made for defeat. A man can be destroyed but not defeated",
            "There is nothing permanent except change",
            "You cannot shake hands with a clenched fist",
            "Learning never exhausts the mind",
            "All tgat we see or seem is but a dream within a dream",
            "The only journey is the one within",
            "The supreme art of war is to subdue the enemy without fighting",
            "Keep your face always toward the sunshine - and shadows will fall behind you",
            "The journes of a thousand miles beings with one step",
            "I have not failed. I've just found 10,000 ways that won't work",
            "If opportunity doesn't knock, build a door"
        };

        /// <summary>
        /// Fähigkeiten (Ability)
        /// </summary>
        static public string[,] Faehigkeiten =
        {
            { "Fliegen", "Hero fliegt in der Luft" },
            { "Feuerball", "Hero schießt Feuerbälle aus den Händen" },
            { "Eislanze", "Hero zaubert Eislanzen aus dem nichts und wirft sie" },
            { "Donnerblitz", "Hero beschwört einen Donner vom Himmel" },
            { "Unsichbarkeit", "Hero wird unsichtbar" },
            { "Dornenpanzer", "Zugefügter Schaden wird um die Hälfte zurück reflektiert" },
            

        };

        /// <summary>
        /// Bestimmte Zeichen
        /// </summary>
        public const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                    "abcdefghijklmnopqrstuvwxyz" +
                                    "0123456789"; 

    }
}
