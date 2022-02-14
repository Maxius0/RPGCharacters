using System;

namespace RPGCharacters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        protected AttributeSet BaseAttributes { get; set; }
        protected AttributeSet TotalAttributes { get; set; }
        protected string PrimaryAttribute { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public void LevelUp()
        {
            this.Level++;
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
