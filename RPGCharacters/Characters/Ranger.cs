namespace RPGCharacters
{
    public class Ranger : Character
    {
        private const int baseStr = 1;
        private const int baseDex = 7;
        private const int baseInt = 1;
        private const AttributeType primary = AttributeType.dexterity;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 5;
        private const int lvlUpInt = 1;


        public Ranger(string name) : base(name)
        {
            CharacterClass = "Ranger";
            BaseAttributes = new AttributeSet(new Attribute(AttributeType.strength, baseStr),
                                              new Attribute(AttributeType.dexterity, baseDex),
                                              new Attribute(AttributeType.intelligence, baseInt));
            LevelUpAttributes = new AttributeSet(new Attribute(AttributeType.strength, lvlUpStr),
                                                 new Attribute(AttributeType.dexterity, lvlUpDex),
                                                 new Attribute(AttributeType.intelligence, lvlUpInt));
        }
    }
}
