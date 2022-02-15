using System;

namespace RPGCharacters
{
    public static class CharacterPrinter
    {
        public static void DisplayStats(string characterString)
        {
            Console.WriteLine("<<< Character Sheet >>>");
            Console.WriteLine(characterString);
            Console.WriteLine();
        }
    }
}
