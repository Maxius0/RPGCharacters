namespace RPGCharacters
{
    public enum Slot
    {
        Head,
        Body,
        Legs,
        Weapon
    }

    /// <summary>
    /// The item super class which contains shared properties and methods for all types of items.
    /// </summary>
    public abstract class Item
    {
        public Slot Slot { get; protected set; }
        public string Name { get; protected set; }
        public int RequiredLevel { get; protected set; } = 1;

        /// <summary>
        /// Checks if the item is equipable based on a character's level and eligible weapon- and armor types.
        /// </summary>
        /// <param name="characterLevel"></param>
        /// <param name="characterWeapons"></param>
        /// <param name="characterArmor"></param>
        /// <returns></returns>
        public abstract string Equipable(int characterLevel, WeaponType[] characterWeapons, ArmorType[] characterArmor);
    }
}
