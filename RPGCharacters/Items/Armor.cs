using System;
using System.Linq;
using System.Text;

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

        public override string Equipable(int characterLevel, WeaponType[] _, ArmorType[] characterArmor)
        {
            if (!characterArmor.Contains(Type))
            {
                throw new InvalidArmorException("Character cannot equip this armor type.");
            }
            if (characterLevel < RequiredLevel)
            {
                throw new InvalidArmorException("Character's level is not high enough.");
            }
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
