using System;

namespace RPGCharacters
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException(string problem)
            : base($"Unable to equip weapon: {problem}")
        {

        }
    }
}
