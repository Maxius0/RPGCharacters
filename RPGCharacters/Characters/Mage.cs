namespace RPGCharacters
{
    public class Mage : Character
    {
        private const int baseStr = 1;
        private const int baseDex = 1;
        private const int baseInt = 8;
        private const Attribute.attributeType primary = Attribute.attributeType.intelligence;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 1;
        private const int lvlUpInt = 5;
            

        public Mage(string name) : base(name)
        {
            BaseAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, baseStr),
                                              new Attribute(Attribute.attributeType.dexterity, baseDex),
                                              new Attribute(Attribute.attributeType.intelligence, baseInt), primary);
            LevelUpAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, lvlUpStr),
                                                 new Attribute(Attribute.attributeType.dexterity, lvlUpDex),
                                                 new Attribute(Attribute.attributeType.intelligence, lvlUpInt), primary);
        }
    }
}
