namespace RPGCharacters
{
    public class Ranger : Character
    {
        private const int baseStr = 1;
        private const int baseDex = 7;
        private const int baseInt = 1;
        private const AttributeType primary = AttributeType.dexterity;
        private const int lvlUpStr = 1;
        private const int lvlUpDex = 5;
        private const int lvlUpInt = 1;


        public Ranger(string name)
        {
            Name = name;
            CharacterClass = "Ranger";
            BaseAttributes = new AttributeSet(baseStr, baseDex, baseInt);
            TotalAttributes = new AttributeSet(BaseAttributes);
            LevelUpAttributes = new AttributeSet(lvlUpStr, lvlUpDex, lvlUpInt);
        }
    }
}
