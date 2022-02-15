using System;

namespace RPGCharacters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public AttributeSet BaseAttributes { get; set; }
        public AttributeSet TotalAttributes { get; set; }
        protected AttributeSet LevelUpAttributes { get; set; } 

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
            return $"Name: {this.Name}\nLevel: {this.Level}";
        }

        public static void CharacterSheet(Character character)
        {
            Console.WriteLine("<<< Character Sheet >>>");
            Console.WriteLine(character.ToString());
        }
    }
}
