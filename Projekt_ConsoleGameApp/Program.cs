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
            List<Hero> liste = new List<Hero>();
            List<XElement> liste2 = new List<XElement>();
            for(int i = 0; i < 500; i++)
            {

                liste2.Add(DataGenerator.Create_Hero_Tree(DataGenerator.Create_Random_Hero()));
            }

            Console.WriteLine(DataGenerator.Create_Heros_Tree(liste2));

            //liste3.ForEach(a => Console.WriteLine(a));

            Console.ReadLine();
        }
    }
}
