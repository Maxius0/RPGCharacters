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
            Console.WriteLine("Welcome to Generic RPG!\n");
            Console.WriteLine("Creating character...\n");
            Warrior testWarrior = new Warrior("Warius");
            CharacterPrinter.DisplayStats(testWarrior.ToString());
            Console.WriteLine("Levelling up character...\n");
            testWarrior.LevelUp();
            CharacterPrinter.DisplayStats(testWarrior.ToString());
            Console.WriteLine("Creating weapon...\n");
            Weapon testAxe = new Weapon("Common axe", 1, WeaponType.Axe, 7.0, 1.1);
            Console.WriteLine("Equipping weapon...\n");
            testWarrior.EquipItem(testAxe);
            CharacterPrinter.DisplayStats(testWarrior.ToString());
            Console.WriteLine("Creating armor piece...\n");
            Armor testPlateBody = new Armor("Common plate body armor", 1, Slot.Body, ArmorType.Plate, new AttributeSet(1, 0, 0));
            Console.WriteLine("Equipping armor piece...\n");
            testWarrior.EquipItem(testPlateBody);
            CharacterPrinter.DisplayStats(testWarrior.ToString());
        }
    }
}
