using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharacters
{
    /// <summary>
    /// The character super class, containing properties and methods shared by all character classes.
    /// </summary>
    public abstract class Character
    {
        public int Level { get; private set; } = 1;
        public AttributeSet BaseAttributes { get; protected set; }
        public AttributeSet TotalAttributes { get; protected set; }
        protected AttributeSet LevelUpAttributes { get; set; }
        protected AttributeType PrimaryAttribute { get; set; }
        public WeaponType[] EligibleWeaponTypes { get; set; }
        public ArmorType[] EligibleArmorTypes { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; } = new Dictionary<Slot, Item>();
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
            AttributeSet bonusAttributes = new AttributeSet(0, 0, 0);
            foreach (KeyValuePair<Slot, Item> kvp in Equipment)
            {
                if (kvp.Key != Slot.Weapon)
                {
                    bonusAttributes += ((Armor)kvp.Value).Attributes;
                }
            }
            TotalAttributes = BaseAttributes + bonusAttributes;
        }

        /// <summary>
        /// Calculates the character's damage based on their weapon DPS and primary attribute. Formula from assignment text appendix B section 4.1.
        /// </summary>
        /// <returns>The damage of the character represented as a double value.</returns>
        public double Damage()
        {
            double weaponDPS = 1;
            if (Equipment.ContainsKey(Slot.Weapon))
            {
                weaponDPS = ((Weapon)Equipment[Slot.Weapon]).DPS();
            }
            return weaponDPS * (1 + ((double)TotalAttributes.GetAttributeValue(PrimaryAttribute)) / 100.0);
        }

        /// <summary>
        /// Attempts to equip given item. If the item is equipable, it is stored in Equipment and a success message is returned.
        /// Otherwise, an appropriate exception is thrown.
        /// </summary>
        /// <param name="item">The item to equip.</param>
        /// <returns>A success message.</returns>
        /// <exception cref="InvalidWeaponException">If item is an invalid weapon.</exception>
        /// <exception cref="InvalidArmorException">If item is an invalid armor piece.</exception>
        public string EquipItem(Item item)
        {
            string result;
            try
            {
                result = item.Equipable(Level, EligibleWeaponTypes, EligibleArmorTypes);
                Equipment[item.Slot] = item;
                UpdateTotalAttributes();
            }
            catch (Exception ex)
            {
                // Re-throw exceptions to satisfy tests.
                throw ex;
            }
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
