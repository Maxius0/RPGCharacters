﻿using System;

namespace RPGCharacters
{
    /// <summary>
    /// The main class, which only purpose is to instantiate the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program execution starts here.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic RPG!\n");
            Mage testMage = new Mage("Mageius");
            Character.DisplayStats(testMage);
            Console.WriteLine("Levelling up character...\n");
            testMage.LevelUp();
            Character.DisplayStats(testMage);
        }
    }
}
