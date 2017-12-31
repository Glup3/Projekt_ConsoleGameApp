using System;

namespace Projekt_ConsoleGameApp
{
    /// <summary>
    /// Startprogramm
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Klasse um Funktionen zu testen
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             *  Code 
             */
            DataGenerator.Write_XML_Tree_NewFile(DataGenerator.Create_Random_Games_Tree(8), "game3");

            Console.ReadLine();
        }
    }
}