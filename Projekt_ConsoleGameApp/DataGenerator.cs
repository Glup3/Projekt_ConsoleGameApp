﻿using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Gibt ein zufälliges Alter zurück
        /// </summary>
        /// <param name="min">Mindest Alter</param>
        /// <param name="max">Maximales Alter</param>
        /// <returns>Alter</returns>
        public static int Random_Age(int min = 1, int max = 201) { return Generator.Next(min, max); }

        /// <summary>
        /// Gibt einen zufälligen Rüstungswert zurück
        /// </summary>
        /// <param name="min">Mindest Rüstungswert</param>
        /// <param name="max">Maximaler Rüstungswert</param>
        /// <returns>Rüstungswert</returns>
        public static double Random_Armor(double min = 0, double max = 30) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt einen zufälligen Angriffsschaden zurück
        /// </summary>
        /// <param name="min">Mindest Angriffsschaden</param>
        /// <param name="max">Maximaler Angriffsschaden</param>
        /// <returns>Angriffsschaden</returns>
        public static double Random_AttackDamage(double min = 10, double max = 500) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt einen zufälligen Lebenspunktewert zurück
        /// </summary>
        /// <param name="min">Mindest Lebenspunktewert</param>
        /// <param name="max">Maximaler Lebenspunktewert</param>
        /// <returns>HP</returns>
        public static double Random_HealthPoints(double min = 50, double max = 20000) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt einen zufälligen Erfahrungspunktwert zurück
        /// </summary>
        /// <param name="min">Mindest Erfahrungspunktwert</param>
        /// <param name="max">Maximaler Erfahrungspunktwert</param>
        /// <returns>ExperiencePoints</returns>
        public static int Random_ExperiencePoints(int min = 0, int max  = 1000) { return Generator.Next(min, max); }

        /// <summary>
        /// Gibt ein zufälliges Level zurück
        /// </summary>
        /// <param name="min">Mindest Level</param>
        /// <param name="max">Maximales Level</param>
        /// <returns>Level</returns>
        public static int Random_Level(int min = 1, int max = 101) { return Generator.Next(min, max); }

        /// <summary>
        /// Gibt einen zufälligen Bewegungsgeschwindigkeitwert zurück
        /// </summary>
        /// <param name="min">Mindest Bewegungsgeschwindigkeit</param>
        /// <param name="max">Maximale Bewegungsgeschwindigkeit</param>
        /// <returns>MovementSpeed</returns>
        public static int Random_MovementSpeed(int min = 1, int max = 43) { return Generator.Next(min, max) * 10; }

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

        /// <summary>
        /// Gibt einen zufälligen String zurück, für Username, Password & InGameName 
        /// </summary>
        /// <param name="length">Länge des Strings</param>
        /// <returns>String</returns>
        public static string Random_String(int length)
        {
            return new string(Enumerable.Repeat(ExampleData.chars, length).Select(s => s[Generator.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Gibt einen zufälligen Geldbetrag zurück
        /// </summary>
        /// <param name="min">Kleinster Wert</param>
        /// <param name="max">Größter Wert</param>
        /// <returns>Geld</returns>
        public static double Random_Money(int min = 0, int max = 10000000) { return Math.Round(Generator.NextDouble() * (max - min) + min, 2); }

        /// <summary>
        /// Gibt einen zufällige Spielzeit zurück
        /// </summary>
        /// <param name="min">Kleinste Zeit</param>
        /// <param name="max">Größter Zeit</param>
        /// <returns>Spielzeit</returns>
        public static int Random_PlayTime(int min = 0, int max = 10001) { return Generator.Next(min, max); }

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
        /// Erstellt einen zufälligen Spieler
        /// </summary>
        /// <returns>Spieler</returns>
        public static Player Create_Random_Player(List<Hero> heros)
        {
            return new Player
            {
                Heros = heros,
                InGameName = Random_String(12),
                Money = Random_Money(),
                Password = Random_String(16),
                PlayedTime = Random_PlayTime(),
                Username = Random_String(8),
            };
        }

        /// <summary>
        /// Erstellt einen XML Tree für Helden, liste von (<see cref="Hero"/>)
        /// </summary>
        /// <param name="heros">XElement Collection von Helden</param>
        /// <returns>XML Tree</returns>
        /// 
        public static XElement Create_Heros_Tree(List<XElement> heros)
        {
            return new XElement("Helden",
                           from h in heros
                           select h);
        }

        public static XElement Create_Heroes_Tree(List<Hero> heros)
        {
            List<XElement> erg = new List<XElement>();
        }

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
                        new XElement("Fähigkeit",
                            new XElement("AbilityName", h.SpecialAbility.AbilityName),
                            new XElement("AbilityDescription", h.SpecialAbility.AbilityDescription)));
        }

        /// <summary>
        /// Erstellt einen XML Tree für Monster (<see cref="Monster"/>)
        /// </summary>
        /// <param name="monster"></param>
        /// <returns>XML Tree</returns>
        public static List<XElement> Create_Monster_Tree(List<Monster> monster)
        {
            return (from m in monster
                   select new XElement("Monster",
                       new XAttribute("Rasse", m.MonsterRace),
                       new XAttribute("Seltenheit", m.MonsterRarity),
                       new XElement("Lebenspunkte", m.HP),
                       new XElement("Angriffsschaden", m.AttackDamage),
                       new XElement("Rüstung", m.Armor),
                       new XElement("Level", m.Level),
                       new XElement("Erfahrungspunkte", m.ExperiencePoints),
                       new XElement("Geschwindigkeit", m.MovementSpeed),
                       new XElement("Alter", m.Age))).ToList();
        }

        //public static List<XElement> Create_Player_Tree(List<Hero> heros, PlayerList player)
        //{
        //    return (from p in player.Get_All_Players()
        //            select new XElement("Spieler",
        //                        new XAttribute("Username", )
        //                )


        //            ).ToList();
        //}

        #endregion

        // 250 Player, 1000 Heros

    }
}