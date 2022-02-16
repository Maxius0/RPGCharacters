using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public enum Slot
    {
        Head,
        Body,
        Legs,
        Weapon
    }

    public abstract class Item
    {
        public Slot Slot { get; protected set; }
        public string Name { get; protected set; }
        public int RequiredLevel { get; protected set; } = 1;

        public abstract string OnEquip(Character character);
    }
}
