using System;

namespace RPGCharacters
{
    /// <summary>
    /// The InvalidWeaponException is thrown when a character attempts to equip an invalid weapon for their class/level.
    /// </summary>
    public class InvalidWeaponException : Exception
    {
        /// <summary>
        /// Uses base Exception constructor. The message given is appended with a string that specifies the problem (level requirement or incorrect type).
        /// </summary>
        /// <param name="problem">The specific problem.</param>
        public InvalidWeaponException(string problem)
            : base($"Unable to equip weapon: {problem}")
        {

        }
    }
}
