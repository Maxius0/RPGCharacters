namespace RPGCharacters
{
    public class AttributeSet
    {
        public Attribute Strength { get; set; } = new Attribute(Attribute.attributeType.strength);
        public Attribute Dexterity { get; set;} = new Attribute(Attribute.attributeType.dexterity);
        public Attribute Intelligence { get; set;} = new Attribute(Attribute.attributeType.intelligence);

        public AttributeSet (int strength, int dexterity, int intelligence, Attribute.attributeType primary)
        {
            Strength.Value = strength;
            Dexterity.Value = dexterity;
            Intelligence.Value = intelligence;
            switch (primary)
            {
                case Attribute.attributeType.strength:
                    Strength.Primary = true;
                    break;
                case Attribute.attributeType.dexterity:
                    Dexterity.Primary = true;
                    break;
                case Attribute.attributeType.intelligence:
                    Intelligence.Primary = true;
                    break;
            }
        }
    }
}
