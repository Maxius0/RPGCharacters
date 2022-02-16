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
        static void Main()
        {
            Console.WriteLine("Welcome to Generic RPG!\n");
            Console.WriteLine("\nCreating character...\n");
            Warrior testWarrior = new Warrior("Warius");
            CharacterPrinter.DisplayStats(testWarrior.ToString());

            Console.WriteLine("\nLevelling up character...\n");
            testWarrior.LevelUp();
            CharacterPrinter.DisplayStats(testWarrior.ToString());

            Console.WriteLine("\nCreating weapon...\n");
            Weapon testAxe = new Weapon("Common axe", 1, WeaponType.Axe, 7.0, 1.1);
            Console.WriteLine(testAxe.ToString());

            Console.WriteLine("\nEquipping weapon...\n");
            Console.WriteLine(testWarrior.EquipItem(testAxe) + "\n");
            CharacterPrinter.DisplayStats(testWarrior.ToString());

            Console.WriteLine("\nCreating armor piece...\n");
            Armor testPlateBody = new Armor("Common plate body armor", 1, Slot.Body, ArmorType.Plate, new AttributeSet(1, 0, 0));
            Console.WriteLine(testPlateBody.ToString());

            Console.WriteLine("\nEquipping armor piece...\n");
            Console.WriteLine(testWarrior.EquipItem(testPlateBody) + "\n");
            CharacterPrinter.DisplayStats(testWarrior.ToString());
        }
    }
}
