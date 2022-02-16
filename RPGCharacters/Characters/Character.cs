using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    /// <summary>
    /// The character super class, containing methods shared by all character classes.
    /// </summary>
    public abstract class Character
    {
        public int Level { get; private set; } = 1;
        public AttributeSet BaseAttributes { get; protected set; }
        public AttributeSet TotalAttributes { get; protected set; }
        public AttributeSet EquipmentAttributes { get; set; } = new AttributeSet(0, 0, 0);
        protected AttributeSet LevelUpAttributes { get; set; }
        protected AttributeType PrimaryAttribute { get; set; }
        public WeaponType[] EligibleWeaponTypes { get; set; }
        public ArmorType[] EligibleArmorTypes { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; } = new Dictionary<Slot, Item>();
        public double WeaponDPS { get; set; } = 1;
        protected string Name { get; set; }
        protected string CharacterClass { get; set; }
        

        /// <summary>
        /// Levels up the character, increasing their level and attributes accordingly.
        /// </summary>
        public void LevelUp()
        {
            Level++;
            BaseAttributes.Add(LevelUpAttributes);
            UpdateTotalAttributes();
        }

        /// <summary>
        /// Updates the character's total attributes based on their base attributes and equipment bonuses.
        /// </summary>
        private void UpdateTotalAttributes()
        {
            TotalAttributes = new AttributeSet(BaseAttributes + EquipmentAttributes);
        }

        /// <summary>
        /// Calculates the character's damage based on their weapon DPS and primary attribute (see assignment text section 4.1).
        /// </summary>
        /// <returns>The damage of the character represented as a double value.</returns>
        public double Damage()
        {
            return WeaponDPS * (1 + ((double) TotalAttributes.GetAttributeValue(PrimaryAttribute)) / 100.0);
        }

        public string EquipItem(Item item)
        {
            string result =  item.OnEquip(this);
            UpdateTotalAttributes();
            return result;
        }

        public override string ToString()
        {
            StringBuilder characterStringBuilder = new StringBuilder();

            characterStringBuilder.Append("Name: ");
            characterStringBuilder.Append(Name);
            characterStringBuilder.Append("\nClass: ");
            characterStringBuilder.Append(CharacterClass);
            characterStringBuilder.Append("\nLevel: ");
            characterStringBuilder.Append(Level);
            characterStringBuilder.Append("\nStrength: ");
            characterStringBuilder.Append(TotalAttributes.GetAttributeValue(AttributeType.Strength));
            characterStringBuilder.Append("\nDexterity: ");
            characterStringBuilder.Append(TotalAttributes.GetAttributeValue(AttributeType.Dexterity));
            characterStringBuilder.Append("\nIntelligence: ");
            characterStringBuilder.Append(TotalAttributes.GetAttributeValue(AttributeType.Intelligence));
            characterStringBuilder.Append("\nDamage: ");
            characterStringBuilder.Append(Damage());

            return characterStringBuilder.ToString();
        }
    }
}
