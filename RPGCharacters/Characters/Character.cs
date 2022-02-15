using System;
using System.Text;

namespace RPGCharacters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public AttributeSet BaseAttributes { get; set; }
        public AttributeSet TotalAttributes { get; set; }
        protected AttributeSet LevelUpAttributes { get; set; }
        protected string characterClass;

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
            characterString.Append(characterClass);
            characterString.Append("\nLevel: ");
            characterString.Append(Level);
            characterString.Append("\nStrength: ");
            characterString.Append(BaseAttributes.GetAttribute(Attribute.attributeType.strength).Value);
            characterString.Append("\nDexterity: ");
            characterString.Append(BaseAttributes.GetAttribute(Attribute.attributeType.dexterity).Value);
            characterString.Append("\nIntelligence: ");
            characterString.Append(BaseAttributes.GetAttribute(Attribute.attributeType.intelligence).Value);
            return characterString.ToString();
        }

        public static void DisplayStats(Character character)
        {
            Console.WriteLine("<<< Character Sheet >>>");
            Console.WriteLine(character.ToString());
            Console.WriteLine();
        }
    }
}
