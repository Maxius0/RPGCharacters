namespace RPGCharacters
{
    public class Warrior : Character
    {
        private const int baseStr = 5;
        private const int baseDex = 2;
        private const int baseInt = 1;
        private const Attribute.attributeType primary = Attribute.attributeType.strength;
        private const int lvlUpStr = 3;
        private const int lvlUpDex = 2;
        private const int lvlUpInt = 1;


        public Warrior(string name) : base(name)
        {
            characterClass = "Warrior";
            BaseAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, baseStr),
                                              new Attribute(Attribute.attributeType.dexterity, baseDex),
                                              new Attribute(Attribute.attributeType.intelligence, baseInt), primary);
            LevelUpAttributes = new AttributeSet(new Attribute(Attribute.attributeType.strength, lvlUpStr),
                                                 new Attribute(Attribute.attributeType.dexterity, lvlUpDex),
                                                 new Attribute(Attribute.attributeType.intelligence, lvlUpInt), primary);
        }
    }
}
