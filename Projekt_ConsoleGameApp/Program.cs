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
            /*
            try
            {
                DataGenerator.Write_XML_Tree_NewFile(DataGenerator.Create_Random_Games_Tree(), "game2.xml");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            

            for (int i = 0; i < 10; i++)
            {
                Hero h = DataGenerator.Create_Random_Hero();
                Hero h2 = DataGenerator.Create_Random_Hero();
                Player p = DataGenerator.Create_Random_Player(new List<Hero>() { h, h2 });
                XElement erg1 = DataGenerator.Create_Player_Tree(p);
                Console.WriteLine(DataGenerator.Read_XML_Tree_Player(erg1));

            }

            Console.ReadLine();
        }
    }
}