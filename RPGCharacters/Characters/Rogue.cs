namespace RPGCharacters
{
    public class Rogue : Character
    {
        private const int baseStr = 2;
        private const int baseDex = 6;
        private const int baseInt = 1;
        private const AttributeType primary = AttributeType.dexterity;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 4;
        private const int lvlUpInt = 1;


        public Rogue(string name) : base(name)
        {
            CharacterClass = "Rogue";
            BaseAttributes = new AttributeSet(new Attribute(AttributeType.strength, baseStr),
                                              new Attribute(AttributeType.dexterity, baseDex),
                                              new Attribute(AttributeType.intelligence, baseInt));
            LevelUpAttributes = new AttributeSet(new Attribute(AttributeType.strength, lvlUpStr),
                                                 new Attribute(AttributeType.dexterity, lvlUpDex),
                                                 new Attribute(AttributeType.intelligence, lvlUpInt));
        }
    }
}
