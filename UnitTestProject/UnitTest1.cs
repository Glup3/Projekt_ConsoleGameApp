﻿using System;
using Projekt_ConsoleGameApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testet die Methode <see cref="DataGenerator.Random_Age(int, int)"/>
        /// </summary>
        [TestMethod]
        public void Test_Random_Age()
        {
            int age = DataGenerator.Random_Age();

            bool between = false;

            if (age > 0 && age < 201)
            {
                between = true;
            }

            Assert.IsTrue(between);
        }

        /// <summary>
        /// Prüft ob das XML File 3 Spiele enthält
        /// </summary>
        [TestMethod]
        public void Test_Game2XML_Count()
        {
            XElement root = XElement.Load("../../XML/game2.xml");

            List<Game> games = DataGenerator.Read_XML_Tree_Games(root);

            Assert.AreEqual(3, games.Count);
        }


    }
}
