using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Startprogramm
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var erg = DataGenerator.Read_XML_Tree_Game(DataGenerator.Create_Random_Game_Tree());

            Console.WriteLine(erg.PlayerListe);

            Console.ReadLine();
        }
    }
}