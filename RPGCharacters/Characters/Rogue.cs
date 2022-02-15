namespace RPGCharacters
{
    public class Rogue : Character
    {
        private const int baseStr = 2;
        private const int baseDex = 6;
        private const int baseInt = 1;
        private const Attribute.attributeType primary = Attribute.attributeType.dexterity;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 4;
        private const int lvlUpInt = 1;


        public Rogue(string name) : base(name)
        {
            characterClass = "Rogue";
            BaseAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, baseStr),
                                              new Attribute(Attribute.attributeType.dexterity, baseDex),
                                              new Attribute(Attribute.attributeType.intelligence, baseInt), primary);
            LevelUpAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, lvlUpStr),
                                                 new Attribute(Attribute.attributeType.dexterity, lvlUpDex),
                                                 new Attribute(Attribute.attributeType.intelligence, lvlUpInt), primary);
        }
    }
}
