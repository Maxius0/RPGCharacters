using System;

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
            Console.WriteLine("Welcome to Generic RPG!");
            Mage testMage = new Mage("Mageius");
            Character.CharacterSheet(testMage);
            Console.WriteLine("Levelling up character...");
            testMage.LevelUp();
            Character.CharacterSheet(testMage);
        }
    }
}
