namespace RPGCharacters
{
    public class Attribute
    {
        public enum attributeType
        {
            strength,
            dexterity,
            intelligence
        }

        public attributeType Type { get; set; }
        public int Value { get; set; } = 0;
        public bool Primary { get; set; } = false;

        public Attribute(attributeType type)
        {
            Type = type;
        }

        public Attribute(attributeType type, int value, bool primary)
        {
            Type = type;
            Value = value;
            Primary = primary;
        }

        public Attribute(Attribute copy)
        {
            Type = copy.Type;
            Value = copy.Value;
            Primary = copy.Primary;
        }

        public void Add(Attribute addend)
        {
            if (this.Type == addend.Type)
            {
                this.Value += addend.Value;
            }
        }

        public static Attribute operator +(Attribute addend1, Attribute addend2)
        {
            Attribute result = new Attribute(addend1);
            result.Add(addend2);
            return result;
        }
    }
}
