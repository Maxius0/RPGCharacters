namespace RPGCharacters
{
    public class Mage : Character
    {
        private const int baseStr = 1;
        private const int baseDex = 1;
        private const int baseInt = 8;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 1;
        private const int lvlUpInt = 5;

        public Mage(string name)
        {
            Name = name;
            CharacterClass = "Mage";
            BaseAttributes = new AttributeSet(baseStr, baseDex, baseInt);
            TotalAttributes = new AttributeSet(BaseAttributes);
            LevelUpAttributes = new AttributeSet(lvlUpStr, lvlUpDex, lvlUpInt);
        }
    }
}
