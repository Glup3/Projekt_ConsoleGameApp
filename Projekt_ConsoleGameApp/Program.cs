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
            Console.WriteLine(DataGenerator.Create_Random_Games_Tree());

            Console.ReadLine();
        }
    }
}
