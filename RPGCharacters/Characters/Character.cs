using System;
using System.Text;

namespace RPGCharacters
{
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

        public void LevelUp()
        {
            Level++;
            BaseAttributes.Add(LevelUpAttributes);
            UpdateTotalAttributes();
        }

        private void UpdateTotalAttributes()
        {
            TotalAttributes = new AttributeSet(BaseAttributes);
        }

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
