using System.Collections.Generic;
using System.Linq;

namespace RPGCharacters
{
    public class AttributeSet
    {
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        public Attribute.attributeType PrimaryAttribute { get; set; }

        public AttributeSet(Attribute strength, Attribute dexterity, Attribute intelligence)
        {
            Attributes.Add(strength);
            Attributes.Add(dexterity);
            Attributes.Add(intelligence);
        }

        public AttributeSet (Attribute strength, Attribute dexterity, Attribute intelligence, Attribute.attributeType primary)
        {
            Attributes.Add(strength);
            Attributes.Add(dexterity);
            Attributes.Add(intelligence);
            PrimaryAttribute = primary;
        }

        public Attribute GetAttribute(Attribute.attributeType type)
        {
            return Attributes.Find(attr => attr.Type == type);
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
