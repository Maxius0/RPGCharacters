using System;
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
        protected AttributeSet LevelUpAttributes { get; set; }
        protected AttributeType PrimaryAttribute { get; set; }
        protected string Name { get; set; }
        protected string CharacterClass { get; set; }
        protected double WeaponDPS { get; set; } = 1.0;

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
            TotalAttributes = new AttributeSet(BaseAttributes);
        }

        /// <summary>
        /// Calculates the character's damage based on their weapon DPS and primary attribute (see assignment text section 4.1).
        /// </summary>
        /// <returns>The damage of the character represented as a double value.</returns>
        public double Damage()
        {
            return WeaponDPS * (1 + ((double) TotalAttributes.GetAttributeValue(PrimaryAttribute)) / 100.0);
        }

        public override string ToString()
        {
            StringBuilder characterString = new StringBuilder();

            characterString.Append("Name: ");
            characterString.Append(Name);
            characterString.Append("\nClass: ");
            characterString.Append(CharacterClass);
            characterString.Append("\nLevel: ");
            characterString.Append(Level);
            characterString.Append("\nStrength: ");
            characterString.Append(TotalAttributes.GetAttributeValue(AttributeType.Strength));
            characterString.Append("\nDexterity: ");
            characterString.Append(TotalAttributes.GetAttributeValue(AttributeType.Dexterity));
            characterString.Append("\nIntelligence: ");
            characterString.Append(TotalAttributes.GetAttributeValue(AttributeType.Intelligence));
            characterString.Append("\nDamage: ");
            characterString.Append(Damage());

            return characterString.ToString();
        }
    }
}
