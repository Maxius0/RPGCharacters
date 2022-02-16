using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
    public class Armor : Item
    {
        public ArmorType Type { get; private set; }
        public AttributeSet Attributes { get; private set; }

        public Armor(string name, int requiredLevel, Slot slot, ArmorType type, AttributeSet attributes)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            Type = type;
            Attributes = new AttributeSet(attributes);
        }
        
    }
}
