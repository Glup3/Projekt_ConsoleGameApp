using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Erstellt zufällige Daten für die Entities (<see cref="Entity"/>) und Spieler (<see cref="Player"/>). <para />
    /// Kann in XML Files Daten speichern und XML Files auslesen.
    /// </summary>
    public static class DataGenerator
    {
        #region Properties

        /// <summary>
        /// Zufallsgenerator
        /// </summary>
        public static Random Generator = new Random();

        #endregion

        #region Methoden

        #region Random Entity Attributes

        /// <summary>
        /// Gibt ein zufälliges Alter zwischen min und max (exklusiv) zurück
        /// </summary>
        /// <param name="min">Mindest Alter, Standardwert = 1</param>
        /// <param name="max">Maximales Alter, Standardwert = 201</param>
        /// <returns>Alter</returns>
        public static int Random_Age(int min = 1, int max = 201) { return Generator.Next(min, max); }

        /// <summary>
        /// Gibt einen zufälligen Rüstungswert zwischen min und max zurück 
        /// </summary>
        /// <param name="min">Mindest Rüstungswert, Standardwert = 0</param>
        /// <param name="max">Maximaler Rüstungswert, Standardwert = 30</param>
        /// <returns>Rüstungswert</returns>
        public static double Random_Armor(double min = 0, double max = 30) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt einen zufälligen Angriffsschaden zwischen min und max zurück
        /// </summary>
        /// <param name="min">Mindest Angriffsschaden, Standardwert = 10</param>
        /// <param name="max">Maximaler Angriffsschaden , Standardwert = 500</param>
        /// <returns>Angriffsschaden</returns>
        public static double Random_AttackDamage(double min = 10, double max = 500) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt einen zufälligen Lebenspunktewert zwischen min und max zurück
        /// </summary>
        /// <param name="min">Mindest Lebenspunktewert, Standardwert = 50</param>
        /// <param name="max">Maximaler Lebenspunktewert, Standardwert = 20000</param>
        /// <returns>HP</returns>
        public static double Random_HealthPoints(double min = 50, double max = 20000) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt einen zufälligen Erfahrungspunktwert zwischen min und max (exklusiv) zurück
        /// </summary>
        /// <param name="min">Mindest Erfahrungspunktwert, Standardwert = 0</param>
        /// <param name="max">Maximaler Erfahrungspunktwert, Standardwert = 1000</param>
        /// <returns>ExperiencePoints</returns>
        public static int Random_ExperiencePoints(int min = 0, int max  = 1000) { return Generator.Next(min, max); }

        /// <summary>
        /// Gibt ein zufälliges Level zwischen min und max (exklusiv) zurück
        /// </summary>
        /// <param name="min">Mindest Level, Standardwert = 1</param>
        /// <param name="max">Maximales Level, Standardwert = 101</param>
        /// <returns>Level</returns>
        public static int Random_Level(int min = 1, int max = 101) { return Generator.Next(min, max); }

        /// <summary>
        /// Gibt einen zufälligen Bewegungsgeschwindigkeitwert zwischen min und max (exklusiv) zurück, Wert wird mit 10 multipliziert
        /// </summary>
        /// <param name="min">Mindest Bewegungsgeschwindigkeit, Standardwert = 1</param>
        /// <param name="max">Maximale Bewegungsgeschwindigkeit, Standardwert = 43</param>
        /// <returns>MovementSpeed</returns>
        public static int Random_MovementSpeed(int min = 1, int max = 43) { return Generator.Next(min, max) * 10; }

        #endregion

        #region Random Hero Attributes

        /// <summary>
        /// Gibt eine zufällige Heldenklasse (<see cref="ClassType"/>) zurück
        /// </summary>
        /// <returns>HeldenKlasse</returns>
        public static ClassType Random_ClassType()
        {
            Array values = Enum.GetValues(typeof(ClassType));
            return (ClassType) values.GetValue(Generator.Next(values.Length));
        }

        /// <summary>
        /// Gibt einen zufälligen Spruch zurück
        /// </summary>
        /// <returns>Motto</returns>
        public static string Random_Motto() { return ExampleData.Sprueche[Generator.Next(ExampleData.Sprueche.Length)]; }

        /// <summary>
        /// Gibt einen zufälligen Namen zurück
        /// </summary>
        /// <returns>Name</returns>
        public static string Random_Name()
        {
            string Vorname = ExampleData.Vornamen[Generator.Next(ExampleData.Vornamen.Length)];
            string Nachname = ExampleData.Nachnamen[Generator.Next(ExampleData.Nachnamen.Length)];

            return $"{Vorname} {Nachname}";
        }

        /// <summary>
        /// Gibt eine zufällige Rasse zurück
        /// </summary>
        /// <returns>Rasse</returns>
        public static RaceType Random_Race()
        {
            Array values = Enum.GetValues(typeof(RaceType));
            return (RaceType)values.GetValue(Generator.Next(values.Length));
        }

        /// <summary>
        /// Gibt eine zufällige Fähigkeit zurück
        /// </summary>
        /// <returns>Fähigkeit</returns>
        public static Ability Random_Ability()
        {
            int i = Generator.Next(ExampleData.Faehigkeiten.Length / 2);
            return new Ability()
            {
                AbilityName = ExampleData.Faehigkeiten[i, 0],
                AbilityDescription = ExampleData.Faehigkeiten[i, 1]
            };
        }

        #endregion

        #region Random Monster Attributes

        /// <summary>
        /// Gibt eine zufällige Monster Rasse zurück
        /// </summary>
        /// <returns>Monster Rasse</returns>
        public static MonsterType Random_MonsterRace()
        {
            Array values = Enum.GetValues(typeof(MonsterType));
            return (MonsterType)values.GetValue(Generator.Next(values.Length));
        }

        /// <summary>
        /// Gibt eine zufällige Monster Rasse zurück
        /// </summary>
        /// <returns>Monster Rasse</returns>
        public static Rarity Random_Rarity()
        {
            Array values = Enum.GetValues(typeof(Rarity));
            return (Rarity)values.GetValue(Generator.Next(values.Length));
        }

        #endregion

        #region Random Player Attributes

        /// <summary>
        /// Gibt eine zufällige Zeichenkette zurück
        /// </summary>
        /// <param name="length">Länge des Strings, Standardwert = 8</param>
        /// <returns>Zeichenkette</returns>
        public static string Random_String(int length = 8)
        {
            return new string(Enumerable.Repeat(ExampleData.chars, length).Select(s => s[Generator.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Gibt einen zufälligen Geldbetrag zwischen min und max zurück
        /// </summary>
        /// <param name="min">Kleinster Wert, Standardwert = 0</param>
        /// <param name="max">Größter Wert, Standardwert = 10000000</param>
        /// <returns>Geld</returns>
        public static double Random_Money(int min = 0, int max = 10000000) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt eine zufällige Spielzeit zwischen min und max (exklusiv) zurück
        /// </summary>
        /// <param name="min">Kleinste Zeit, Standardwert = 0</param>
        /// <param name="max">Größter Zeit, Standardwert = 10001</param>
        /// <returns>Spielzeit</returns>
        public static int Random_PlayTime(int min = 0, int max = 10001) { return Generator.Next(min, max); }

        #endregion

        #region Create Random Hero, Player, Monster, Game

        /// <summary>
        /// Erstellt ein neues Monster mit zufälligen Werten
        /// </summary>
        /// <returns>Monster</returns>
        public static Monster Create_Random_Monster()
        {
            return new Monster
            {
                Age = Random_Age(),
                Armor = Random_Armor(),
                AttackDamage = Random_AttackDamage(),
                ExperiencePoints = Random_ExperiencePoints(),
                HP = Random_HealthPoints(),
                Level = Random_Level(),
                MonsterRace = Random_MonsterRace(),
                MovementSpeed = Random_MovementSpeed(),
                MonsterRarity = Random_Rarity(),
            };
        }

        /// <summary>
        /// Erstellt eine zufällige Liste von Monstern
        /// </summary>
        /// <param name="anz">Anzahl der Monster, Standartwert = 50</param>
        /// <returns>Liste von Monstern</returns>
        public static List<Monster> Create_Random_Monsters(int anz = 50)
        {
            List<Monster> liste = new List<Monster>();
            for(int i = 0; i < anz; i++)
            {
                liste.Add(Create_Random_Monster());
            }

            return liste;
        }

        /// <summary>
        /// Erstellt einen zufälligen Helden
        /// </summary>
        /// <returns>Held</returns>
        public static Hero Create_Random_Hero()
        {
            return new Hero
            {
                Age = Random_Age(),
                Armor = Random_Armor(),
                AttackDamage = Random_AttackDamage(),
                ExperiencePoints = Random_ExperiencePoints(),
                HP = Random_HealthPoints(),
                HeroClass = Random_ClassType(),
                Level = Random_Level(),
                Motto = Random_Motto(),
                MovementSpeed = Random_MovementSpeed(),
                Name = Random_Name(),
                Race = Random_Race(),
                SpecialAbility = Random_Ability(),
            };
        }

        /// <summary>
        /// Erstellt eine zufällige Liste von Helden
        /// </summary>
        /// <param name="anz">Anzahl der Helden, Standardwert = 6</param>
        /// <returns>Liste von Helden</returns>
        public static List<Hero> Create_Random_Heroes(int anz = 6)
        {
            List<Hero> liste = new List<Hero>();
            for (int i = 0; i < anz; i++)
            {
                liste.Add(Create_Random_Hero());
            }
            return liste;
        }

        /// <summary>
        /// Erstellt einen zufälligen Spieler, Liste von Helden wird angegeben
        /// </summary>
        /// <param name="heroes">Liste von Helden</param>
        /// <returns>Zufälligen Spieler</returns>
        public static Player Create_Random_Player(List<Hero> heroes)
        {
            return new Player
            {
                Heroes = heroes,
                InGameName = Random_String(12),
                Money = Random_Money(),
                Password = Random_String(16),
                PlayedTime = Random_PlayTime(),
                Username = Random_String(8),
            };
        }

        /// <summary>
        /// Erstellt einen zufälligen Spieler, Liste von Helden ist zufällig
        /// </summary>
        /// <param name="anz">Anzahl an Helden, Standardwert = 6</param>
        /// <returns>Zufälligen Spieler</returns>
        public static Player Create_Random_Player(int anz = 6)
        {
            return Create_Random_Player(Create_Random_Heroes(anz));
        }

        /// <summary>
        /// Erstellt eine zufällige Liste von Spielern
        /// </summary>
        /// <param name="anz">Anzahl der Spieler, Standardwert = 4</param>
        /// <returns>Spielerliste</returns>
        public static PlayerList Create_Random_PlayerList(int anz = 4)
        {
            PlayerList liste = new PlayerList();
            for(int i = 0; i < anz; i++)
            {
                liste.Add_Player(Create_Random_Player(Create_Random_Heroes()));
            }
            return liste;
        }

        /// <summary>
        /// Erstellt ein zufälliges Spiel (<see cref="Game"/>), Spielerliste und Monsterliste werden angegeben
        /// </summary>
        /// <param name="pl">Spielerliste</param>
        /// <param name="ml">Monsterliste</param>
        /// <returns>Zufälliges Spiel</returns>
        public static Game Create_Random_Game(PlayerList pl, List<Monster> ml)
        {
            return new Game
            {
                GameName = Random_String(),
                MonsterListe = ml,
                PlayerListe = pl,
            };
        }

        /// <summary>
        /// Erstellt ein zufälliges Spiel (<see cref="Game"/>), Spielerliste und Monsterliste sind zufällig
        /// </summary>
        /// <param name="anzPl">Anzahl der Spieler, Standardwert = 4</param>
        /// <param name="anzMl">Anzahl der Monster, Standardwert = 4</param>
        /// <returns>Zufälliges Spiel</returns>
        public static Game Create_Random_Game(int anzPl = 4, int anzMl = 50)
        {
            return Create_Random_Game(Create_Random_PlayerList(anzPl), Create_Random_Monsters(anzMl));
        }

        /// <summary>
        /// Erstellt eine zufällige Liste von Spielen
        /// </summary>
        /// <param name="anz">Anzahl der Spiel, Standardwert = 3</param>
        /// <returns>Zufällige Liste von Spielen</returns>
        public static List<Game> Create_Random_Games(int anz = 3)
        {
            List<Game> liste = new List<Game>();
            for(int i = 0; i < anz; i++)
            {
                liste.Add(Create_Random_Game());
            }

            return liste;
        }

        #endregion

        #region Create XML Hero Tree

        /// <summary>
        /// Erstellt einen XML Tree für Helden aus einer Liste von XElementen
        /// </summary>
        /// <param name="heroes">XElement Collection von Helden</param>
        /// <returns>XML Tree Heroes</returns>
        public static XElement Create_Heroes_Tree(List<XElement> heroes)
        {
            return new XElement("Heroes",
                        new XAttribute("HeroesNumber", heroes.Count),
                        from h in heroes
                        select h);
        }

        /// <summary>
        /// Erstellt einen XML Tree für Helden aus einer Liste von Helden (<see cref="Hero"/>)
        /// </summary>
        /// <param name="heroes">Liste von Heroes</param>
        /// <returns>XML Tree Heroes</returns>
        public static XElement Create_Heroes_Tree(List<Hero> heroes)
        {
            List<XElement> erg = new List<XElement>();
            heroes.ForEach(a => erg.Add(Create_Hero_Tree(a)));

            return Create_Heroes_Tree(erg);
        }

        /// <summary>
        /// Erstellt einen XML für einen Helden
        /// </summary>
        /// <param name="h">Der Hero</param>
        /// <returns>XML Tree Hero</returns>
        public static XElement Create_Hero_Tree(Hero h)
        {
            return new XElement("Held",
                        new XAttribute("Name", h.Name),
                        new XAttribute("Rasse", h.Race),
                        new XElement("HeldenKlasse", h.HeroClass),
                        new XElement("Lebenspunkte", h.HP),
                        new XElement("Angriffsschaden", h.AttackDamage),
                        new XElement("Rüstung", h.Armor),
                        new XElement("Level", h.Level),
                        new XElement("Erfahrungspunkte", h.ExperiencePoints),
                        new XElement("Geschwindigkeit", h.MovementSpeed),
                        new XElement("Alter", h.Age),
                        new XElement("Motto", h.Motto),
                        Create_Ability_Tree(h.SpecialAbility));
        }

        /// <summary>
        /// Erstellt einen XML Tree für Ability (<see cref="Ability"/>)
        /// </summary>
        /// <param name="ability">Fähigkeit des Helden</param>
        /// <returns>XML Tree Ability</returns>
        public static XElement Create_Ability_Tree(Ability ability)
        {
            return new XElement("Fähigkeit",
                            new XElement("AbilityName", ability.AbilityName),
                            new XElement("AbilityDescription", ability.AbilityDescription));
        }

        #endregion

        #region Create XML Monster Tree

        /// <summary>
        /// Erstellt einen XML Tree für ein Monster (<see cref="Monster"/>)
        /// </summary>
        /// <param name="m">Ein Monster</param>
        /// <returns>XML Tree Monster</returns>
        public static XElement Create_Monster_Tree(Monster m)
        {
            return new XElement("Monster",
                        new XAttribute("Rasse", m.MonsterRace),
                        new XAttribute("Seltenheit", m.MonsterRarity),
                        new XElement("Lebenspunkte", m.HP),
                        new XElement("Angriffsschaden", m.AttackDamage),
                        new XElement("Rüstung", m.Armor),
                        new XElement("Level", m.Level),
                        new XElement("Erfahrungspunkte", m.ExperiencePoints),
                        new XElement("Geschwindigkeit", m.MovementSpeed),
                        new XElement("Alter", m.Age));
        }

        /// <summary>
        /// Erstellt einen XML Tree für Monsters aus einer Liste von XElementen
        /// </summary>
        /// <param name="monsters">XML Liste von Monstern</param>
        /// <returns>XML Tree Monsters</returns>
        public static XElement Create_Monsters_Tree(List<XElement> monsters)
        {
            return new XElement("Monsters",
                        from m in monsters
                        select m);
        }

        /// <summary>
        /// Erstellt einen XML Tree für Monsters aus einer Liste von Monstern
        /// </summary>
        /// <param name="monsters">Liste von Monstern</param>
        /// <returns>XML Tree Monsters</returns>
        public static XElement Create_Monsters_Tree(List<Monster> monsters)
        {
            List<XElement> erg = new List<XElement>();
            monsters.ForEach(m => erg.Add(Create_Monster_Tree(m)));

            return Create_Monsters_Tree(erg);
        }

        #endregion

        #region Create XML Player Tree

        /// <summary>
        /// Erstellt einen XML Tree für einen Player
        /// </summary>
        /// <param name="p">Der Spieler</param>
        /// <returns>XML Tree Player</returns>
        public static XElement Create_Player_Tree(Player p)
        {
            return new XElement("Player", 
                        new XAttribute("Username", p.Username),
                        new XAttribute("Password", p.Password),
                        new XElement("InGameName", p.InGameName),
                        new XElement("Money", p.Money),
                        new XElement("Spielzeit", p.PlayedTime),
                        Create_Heroes_Tree(p.Heroes));
        }

        /// <summary>
        /// Erstellt einen XML Tree für Spieler aus einer Liste von Spielern (<see cref="PlayerList"/>)
        /// </summary>
        /// <param name="pl">Spielerliste</param>
        /// <returns>XML Tree Players</returns>
        public static XElement Create_Players_Tree(PlayerList pl)
        {
            List<XElement> erg = new List<XElement>();
            pl.Get_All_Players().ForEach(p => erg.Add(Create_Player_Tree(p)));

            return Create_Players_Tree(erg);
        }

        /// <summary>
        /// Erstellt einen XML Tree für Spieler aus einer Liste von XElementen
        /// </summary>
        /// <param name="players">XML Tree von Spielern ohne "Players"</param>
        /// <returns></returns>
        public static XElement Create_Players_Tree(List<XElement> players)
        {
            return new XElement("Players",
                        new XAttribute("PlayersNumber", players.Count),
                        from p in players
                        select p);
        }

        #endregion

        #region Create XML Game Tree

        /// <summary>
        /// Erstellt einen XML Tree für ein Spiel
        /// </summary>
        /// <param name="g">Das Spiel</param>
        /// <returns>XML Tree Game</returns>
        public static XElement Create_Game_Tree(Game g)
        {
            return new XElement("Game",
                        new XAttribute("GameName", g.GameName),
                        Create_Players_Tree(g.PlayerListe),
                        Create_Monsters_Tree(g.MonsterListe));
        }

        /// <summary>
        /// Erstellt einen XML Tree für Spiele aus einer Liste von XElementen
        /// </summary>
        /// <param name="games">XElement Liste von Spielen</param>
        /// <returns>XML Tree Games</returns>
        public static XElement Create_Games_Tree(List<XElement> games)
        {
            return new XElement("Games",
                        new XAttribute("GamesNumber", games.Count),
                        from g in games
                        select g);
        }

        /// <summary>
        /// Erstellt einen XML Tree für Spiele aus einer Liste von Spielen
        /// </summary>
        /// <param name="games">Liste von Spielen</param>
        /// <returns>XML Tree Games</returns>
        public static XElement Create_Games_Tree(List<Game> games)
        {
            List<XElement> erg = new List<XElement>();
            games.ForEach(g => erg.Add(Create_Game_Tree(g)));

            return Create_Games_Tree(erg);
        }

        #endregion

        #region Create Random XML Trees

        /// <summary>
        /// Erstellt einen zufälligen XML Tree für eine Fähigkeit (<see cref="Ability"/>)
        /// </summary>
        /// <returns>XML Tree Ability</returns>
        public static XElement Create_Random_Ability_Tree()
        {
            return Create_Ability_Tree(Random_Ability());
        }

        /// <summary>
        /// Erstellt einen zufälligen XML Tree für Helden
        /// </summary>
        /// <param name="anz">Anzahl der Helden, Standardwert = 6</param>
        /// <returns>XML Tree Heroes</returns>
        public static XElement Create_Random_Heroes_Tree(int anz = 6)
        {
            return Create_Heroes_Tree(Create_Random_Heroes(anz));
        }

        /// <summary>
        /// Erstellt einen zufälligen XML Tree für Spieler
        /// </summary>
        /// <param name="anz">Anzahl der Spieler, Standardwert = 4</param>
        /// <returns>XML Tree Players</returns>
        public static XElement Create_Random_Players_Tree(int anz = 4)
        {
            return Create_Players_Tree(Create_Random_PlayerList(anz));
        }

        /// <summary>
        /// Erstellt einen zufälligen XML Tree für Monsters
        /// </summary>
        /// <param name="anz">Anzahl der Monster, Standardwert = 50</param>
        /// <returns>XML Tree Monsters</returns>
        public static XElement Create_Random_Monsters_Tree(int anz = 50)
        {
            return Create_Monsters_Tree(Create_Random_Monsters(anz));
        }

        /// <summary>
        /// Erstellt einen zufälligen XML Tree für Spiele
        /// </summary>
        /// <param name="anz">Anzahl der Spiele, Standardwert = 3</param>
        /// <returns>XML Tree Games</returns>
        public static XElement Create_Random_Games_Tree(int anz = 3)
        {
            return Create_Games_Tree(Create_Random_Games(anz));
        }




        #endregion

        #region File Write, Read

        /// <summary>
        /// Erstellt ein neues XML File und speichert den Tree hinein
        /// </summary>
        /// <param name="tree">XML Tree</param>
        /// <param name="fileName">Name der Datei</param>
        public static void Write_XML_Tree_NewFile(XElement tree, string fileName)
        {
            string path = "../../XML/" + fileName;

            if(File.Exists(path))
            {
                throw new Exception("File existiert bereits");
            }

            tree.Save(path);
        }

        /// <summary>
        /// Liest aus einem XML Baum eine Ability heraus
        /// </summary>
        /// <param name="tree">XML Tree Ability</param>
        /// <returns>Ability</returns>
        public static Ability Read_XML_Tree_Ability(XElement tree)
        {
            return new Ability { AbilityName = tree.Element("AbilityName").Value, AbilityDescription = tree.Element("AbilityDescription").Value };
        }

        /// <summary>
        /// Liest aus einem XML Baum einen Helden heraus
        /// </summary>
        /// <param name="tree">XML Tree Hero</param>
        /// <returns>Hero</returns>
        public static Hero Read_XML_Tree_Hero(XElement tree)
        {
            return new Hero
            {
                Age = Int32.Parse(tree.Element("Alter").Value),
                Armor = Double.Parse(tree.Element("Rüstung").Value.Replace('.', ',')),
                AttackDamage = Double.Parse(tree.Element("Angriffsschaden").Value.Replace('.', ',')),
                ExperiencePoints = Int32.Parse(tree.Element("Erfahrungspunkte").Value),
                HeroClass = (ClassType) Enum.Parse(typeof(ClassType), tree.Element("HeldenKlasse").Value),
                HP = Double.Parse(tree.Element("Lebenspunkte").Value.Replace('.', ',')),
                Level = Int32.Parse(tree.Element("Level").Value),
                Motto = tree.Element("Motto").Value,
                MovementSpeed = Int32.Parse(tree.Element("Geschwindigkeit").Value),
                Name = tree.Attribute("Name").Value,
                Race = (RaceType)Enum.Parse(typeof(RaceType), tree.Attribute("Rasse").Value),
                SpecialAbility = Read_XML_Tree_Ability(tree.Element("Fähigkeit")),
            }; 
        }

        /// <summary>
        /// Liest aus einem XML Baum alle Helden heraus
        /// </summary>
        /// <param name="tree">XML Tree Heroes</param>
        /// <returns>Liste von Helden</returns>
        public static List<Hero> Read_XML_Tree_Heroes(XElement tree)
        {
            List<Hero> liste = new List<Hero>();
            var erg = tree.Elements("Held");
            erg.ToList().ForEach(h => liste.Add(Read_XML_Tree_Hero(h)));
            return liste;
        }

        /// <summary>
        /// Liest aus einem XML Baum einen Helden heraus
        /// </summary>
        /// <param name="tree">XML Tree Player</param>
        /// <returns>Player</returns>
        public static Player Read_XML_Tree_Player(XElement tree)
        {
            return new Player
            {
                Heroes = Read_XML_Tree_Heroes(tree.Element("Heroes")),
                InGameName = tree.Element("InGameName").Value,
                Money = Double.Parse(tree.Element("Money").Value.Replace('.', ',')),
                Password = tree.Attribute("Password").Value,
                Username = tree.Attribute("Username").Value,
                PlayedTime = Int32.Parse(tree.Element("Spielzeit").Value)
            };
        }

        #endregion

        #endregion

    }
}
