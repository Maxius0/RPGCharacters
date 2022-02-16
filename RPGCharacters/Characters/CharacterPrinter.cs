using System;

namespace RPGCharacters
{
    /// <summary>
    /// The character printer's sole purpose is to print character sheets.
    /// </summary>
    public static class CharacterPrinter
    {
        /// <summary>
        /// Prints the character sheet of a character, given its character string (can be created using Character.ToString)
        /// </summary>
        /// <param name="characterString">The string representation of the character whose character sheet will be printed.</param>
        public static void DisplayStats(string characterString)
        {
            Console.WriteLine("<<< Character Sheet >>>");
            Console.WriteLine(characterString);
        }
    }
}
