namespace RPGCharacters
{
    public enum AttributeType
    {
        Strength,
        Dexterity,
        Intelligence
    }

    public class Attribute
    {


        public AttributeType Type { get; set; }
        public int Value { get; set; } = 0;

        public Attribute(AttributeType type)
        {
            Type = type;
        }

        public Attribute(AttributeType type, int value)
        {
            Type = type;
            Value = value;
        }

        public Attribute(Attribute copy)
        {
            Type = copy.Type;
            Value = copy.Value;
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

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Attribute))
            {
                return false;
            }
            return Type == ((Attribute)obj).Type && Value == ((Attribute)obj).Value; 
        }

        public static bool operator ==(Attribute compare1, Attribute compare2)
        {
            return compare1.Equals(compare2);
        }
        public static bool operator !=(Attribute compare1, Attribute compare2)
        {
            return !compare1.Equals(compare2);
        }

    }
}
