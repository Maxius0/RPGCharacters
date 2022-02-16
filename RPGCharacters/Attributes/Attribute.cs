using System;

namespace RPGCharacters
{
    public enum AttributeType
    {
        Strength,
        Dexterity,
        Intelligence
    }

    /// <summary>
    /// An attribute consists of an AttributeType (Strength/Dexterity/Intelligence) and an integer value.
    /// An attribute can be copied, added and compared to other attributes.
    /// </summary>
    public class Attribute
    {
        public AttributeType Type { get; set; }
        public int Value { get; set; } = 0;

        public Attribute(AttributeType type, int value)
        {
            Type = type;
            Value = value;
        }

        public Attribute(Attribute copy)
        {
            Type = copy.Type;
            Value = copy.Value;
        }

        /// <summary>
        /// Adds two attributes together by adding their values.
        /// </summary>
        /// <param name="addend">The attribute to add.</param>
        /// <exception>ArgumentException if the addends are not of the same attribute type.</exception>
        public void Add(Attribute addend)
        {
            if (this.Type == addend.Type)
            {
                this.Value += addend.Value;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static Attribute operator +(Attribute addend1, Attribute addend2)
        {
            Attribute result = new Attribute(addend1);
            result.Add(addend2);
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Attribute))
            {
                return false;
            }
            return Type == ((Attribute)obj).Type && Value == ((Attribute)obj).Value;
        }

        public static bool operator ==(Attribute compare1, Attribute compare2)
        {
            return compare1.Equals(compare2);
        }
        public static bool operator !=(Attribute compare1, Attribute compare2)
        {
            return !compare1.Equals(compare2);
        }

    }
}
