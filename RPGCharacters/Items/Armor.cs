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

        public override string OnEquip(Character character)
        {
            character.EquipmentAttributes = Attributes;
            character.Equipment[Slot] = this;
            return "New armor equipped!";
        }

        public override string ToString()
        {
            StringBuilder weaponStringBuilder = new StringBuilder(Name);
            weaponStringBuilder.Append("\nStrength: ");
            weaponStringBuilder.Append(Attributes.GetAttributeValue(AttributeType.Strength));
            weaponStringBuilder.Append("\nDexterity: ");
            weaponStringBuilder.Append(Attributes.GetAttributeValue(AttributeType.Dexterity));
            weaponStringBuilder.Append("\nIntelligence: ");
            weaponStringBuilder.Append(Attributes.GetAttributeValue(AttributeType.Intelligence));

            return weaponStringBuilder.ToString();
        }
    }
}
