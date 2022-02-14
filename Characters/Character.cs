using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters { 
    public abstract class Character
    {
        private string Name { get; set; }
        private int Level { get; set; } = 1;
        private Attribute[] BaseAttributes { get; set; }
        private Attribute[] TotalAttributes { get; set; }
        private string PrimaryAttribute { get; set; }

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
