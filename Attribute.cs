using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public class Attribute
    {
        private string Type { get; set; }
        private int Value { get; set; }
        private bool Primary { get; set; }

        public Attribute(string type, int value, bool primary)
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

        public static Attribute operator + (Attribute addend1, Attribute addend2)
        {
            Attribute result = new Attribute(addend1);
            result.Add(addend2);
            return result;
        } 
    }
}
