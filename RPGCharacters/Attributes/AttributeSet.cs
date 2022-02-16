using System.Collections.Generic;
using System.Linq;

namespace RPGCharacters
{
    /// <summary>
    /// An attribute set consists of a list of attributes.
    /// An attribute set can be copied, added and compared to other attribute sets.
    /// An attribute set can retrieve the value of any attribute in the set.
    /// </summary>
    public class AttributeSet
    {
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        public AttributeSet(int strength, int dexterity, int intelligence)
        {
            Attributes.Add(new Attribute(AttributeType.Strength, strength));
            Attributes.Add(new Attribute(AttributeType.Dexterity, dexterity));
            Attributes.Add(new Attribute(AttributeType.Intelligence, intelligence));
        }

        public AttributeSet(AttributeSet copy)
        {
            Attributes = new List<Attribute>(copy.Attributes);
        }

        /// <summary>
        /// Retrieves the value of any atrribute in this attribute set of the given attribute type.
        /// </summary>
        /// <param name="type">The type of the attribute to get a value from.</param>
        /// <returns>The value of the attribute.</returns>
        public int GetAttributeValue(AttributeType type)
        {
            return Attributes.Find(attr => attr.Type == type).Value;
        }

        /// <summary>
        /// Adds two attribute sets together by adding each attribute pair.
        /// </summary>
        /// <param name="addend">The attribute set to add.</param>
        public void Add(AttributeSet addend)
        {
            Attributes = new List<Attribute>(Attributes.Zip(addend.Attributes, ((attr1, attr2) => attr1 + attr2)));
        }

        public static AttributeSet operator +(AttributeSet addend1, AttributeSet addend2)
        {
            AttributeSet result = new AttributeSet(addend1);
            result.Add(addend2);
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is AttributeSet))
            {
                return false;
            }

            return Attributes.SequenceEqual(((AttributeSet)obj).Attributes);
        }
    }
}
