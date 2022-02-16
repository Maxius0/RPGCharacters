namespace RPGCharacters
{
    /// <summary>
    /// The warrior character class. See assignment text appendix 3.4 for specification.
    /// </summary>
    public class Warrior : Character
    {
        private const int baseStr = 5;
        private const int baseDex = 2;
        private const int baseInt = 1;
        private const AttributeType primary = AttributeType.Strength;
        private const int lvlUpStr = 3;
        private const int lvlUpDex = 2;
        private const int lvlUpInt = 1;


        public Warrior(string name)
        {
            Name = name;
            CharacterClass = "Warrior";
            BaseAttributes = new AttributeSet(baseStr, baseDex, baseInt);
            TotalAttributes = new AttributeSet(BaseAttributes);
            LevelUpAttributes = new AttributeSet(lvlUpStr, lvlUpDex, lvlUpInt);
            EligibleWeaponTypes = new WeaponType[] { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword };
            EligibleArmorTypes = new ArmorType[] { ArmorType.Mail, ArmorType.Plate};
        }
    }
}
