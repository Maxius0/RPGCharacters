namespace RPGCharacters
{
    public class Warrior : Character
    {
        private const int baseStr = 5;
        private const int baseDex = 2;
        private const int baseInt = 1;
        private const AttributeType primary = AttributeType.strength;
        private const int lvlUpStr = 3;
        private const int lvlUpDex = 2;
        private const int lvlUpInt = 1;


        public Warrior(string name) : base(name)
        {
            CharacterClass = "Warrior";
            BaseAttributes = new AttributeSet(new Attribute(AttributeType.strength, baseStr),
                                              new Attribute(AttributeType.dexterity, baseDex),
                                              new Attribute(AttributeType.intelligence, baseInt));
            LevelUpAttributes = new AttributeSet(new Attribute(AttributeType.strength, lvlUpStr),
                                                 new Attribute(AttributeType.dexterity, lvlUpDex),
                                                 new Attribute(AttributeType.intelligence, lvlUpInt));
        }
    }
}
