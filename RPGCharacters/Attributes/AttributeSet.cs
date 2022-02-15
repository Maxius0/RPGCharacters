using System.Collections.Generic;
using System.Linq;

namespace RPGCharacters
{
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

        public int GetAttributeValue(AttributeType type)
        {
            return Attributes.Find(attr => attr.Type == type).Value;
        }

        public void Add(AttributeSet addend)
        {
            for (int i = 0; i < Attributes.Count; i++)
            {
                Attributes[i].Add(addend.Attributes[i]);
            }
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
