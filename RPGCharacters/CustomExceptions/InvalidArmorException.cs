using System;

namespace RPGCharacters
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(string problem)
            : base($"Unable to equip armor piece: {problem}")
        {

        }
    }
}
