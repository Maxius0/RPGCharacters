using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }
    public class Weapon : Item
    {
        public WeaponType Type { get; private set;}
        private double Damage { get; set;}
        private double AttackSpeed { get; set;}

        public Weapon(string name, int requiredLevel, WeaponType type, double damage, double attackSpeed)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = Slot.Weapon;
            Type = type;
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        public double DPS()
        {
            return Damage * AttackSpeed;
        }
    }
}
