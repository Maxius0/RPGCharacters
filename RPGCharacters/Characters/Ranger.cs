namespace RPGCharacters
{
    public class Ranger : Character
    {
        private const int baseStr = 1;
        private const int baseDex = 7;
        private const int baseInt = 1;
        private const Attribute.attributeType primary = Attribute.attributeType.dexterity;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 5;
        private const int lvlUpInt = 1;


        public Ranger(string name) : base(name)
        {
            characterClass = "Ranger";
            BaseAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, baseStr),
                                              new Attribute(Attribute.attributeType.dexterity, baseDex),
                                              new Attribute(Attribute.attributeType.intelligence, baseInt), primary);
            LevelUpAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, lvlUpStr),
                                                 new Attribute(Attribute.attributeType.dexterity, lvlUpDex),
                                                 new Attribute(Attribute.attributeType.intelligence, lvlUpInt), primary);
        }
    }
}
