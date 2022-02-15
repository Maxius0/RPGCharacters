using System;
using System.Text;

namespace RPGCharacters
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public int Level { get; private set; } = 1;
        public AttributeSet BaseAttributes { get; protected set; }
        public AttributeSet TotalAttributes { get; protected set; }
        protected AttributeSet LevelUpAttributes { get; set; }
        protected string CharacterClass { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public void LevelUp()
        {
            Level++;
            BaseAttributes.Add(LevelUpAttributes);
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
            characterString.Append(BaseAttributes.GetAttribute(AttributeType.strength).Value);
            characterString.Append("\nDexterity: ");
            characterString.Append(BaseAttributes.GetAttribute(AttributeType.dexterity).Value);
            characterString.Append("\nIntelligence: ");
            characterString.Append(BaseAttributes.GetAttribute(AttributeType.intelligence).Value);

            return characterString.ToString();
        }
    }
}
