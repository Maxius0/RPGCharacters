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

        public override string OnEquip(Character character)
        {
            character.WeaponDPS = DPS();
            character.Equipment[Slot] = this;
            return "New weapon equipped!";
        }

        public override string ToString()
        {
            StringBuilder weaponStringBuilder = new StringBuilder(Name);
            weaponStringBuilder.Append("\nDamage: ");
            weaponStringBuilder.Append(Damage);
            weaponStringBuilder.Append("\nAttack speed: ");
            weaponStringBuilder.Append(AttackSpeed);
            weaponStringBuilder.Append("\nDPS: ");
            weaponStringBuilder.Append(DPS());

            return weaponStringBuilder.ToString();
        }
    }
}
