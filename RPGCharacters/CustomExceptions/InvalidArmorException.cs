using System;

namespace RPGCharacters
{
    /// <summary>
    /// The InvalidArmorException is thrown when a character attempts to equip an invalid armor piece for their class/level.
    /// </summary>
    public class InvalidArmorException : Exception
    {
        /// <summary>
        /// Uses base Exception constructor. The message given is appended with a string that specifies the problem (level requirement or incorrect type).
        /// </summary>
        /// <param name="problem">The specific problem.</param>
        public InvalidArmorException(string problem)
            : base($"Unable to equip armor piece: {problem}")
        {

        }
    }
}
