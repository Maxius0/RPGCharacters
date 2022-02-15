namespace RPGCharacters
{
    public class Mage : Character
    {
        private const int baseStr = 1;
        private const int baseDex = 1;
        private const int baseInt = 8;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 1;
        private const int lvlUpInt = 5;
            

        public Mage(string name) : base(name)
        {
            CharacterClass = "Mage";
            BaseAttributes = new AttributeSet(new Attribute(AttributeType.strength, baseStr),
                                              new Attribute(AttributeType.dexterity, baseDex),
                                              new Attribute(AttributeType.intelligence, baseInt));
            LevelUpAttributes = new AttributeSet(new Attribute(AttributeType.strength, lvlUpStr),
                                                 new Attribute(AttributeType.dexterity, lvlUpDex),
                                                 new Attribute(AttributeType.intelligence, lvlUpInt));
        }
    }
}
