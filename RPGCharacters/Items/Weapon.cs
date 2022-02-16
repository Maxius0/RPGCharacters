using System;
using System.Linq;
using System.Text;

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
    /// <summary>
    /// A weapon is an item with a weapon type, a damage value and an attack speed value. Weapons can only go into the weapon slot.
    /// </summary>
    public class Weapon : Item
    {
        public WeaponType Type { get; private set; }
        private double Damage { get; set; }
        private double AttackSpeed { get; set; }

        public Weapon(string name, int requiredLevel, WeaponType type, double damage, double attackSpeed)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = Slot.Weapon;
            Type = type;
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        /// <summary>
        /// Calculates the DPS (Damage Per Second) of the weapon. Formula from assignment appendix B section 2.
        /// </summary>
        /// <returns>The DPS of the weapon.</returns>
        public double DPS()
        {
            return Damage * AttackSpeed;
        }

        public override string Equipable(int characterLevel, WeaponType[] characterWeapons, ArmorType[] _)
        {
            if (!characterWeapons.Contains(Type))
            {
                throw new InvalidWeaponException("Character cannot equip this weapon type.");
            }
            if (characterLevel < RequiredLevel)
            {
                throw new InvalidWeaponException("Character's level is not high enough.");
            }
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
