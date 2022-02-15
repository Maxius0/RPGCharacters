using RPGCharacters;
using System.Collections.Generic;
using Xunit;

namespace RPGCharactersTests
{
    public class CharacterTests
    {
        [Fact]
        public void Constructor_InitializeWithName_ShouldCreateCharacterAtLevelOne()
        {
            // Arrange
            Mage character;
            int expected = 1;

            // Act
            character = new Mage("Character");
            int actual = character.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_CallOnNewCharacter_ShouldIncreaseCharacterLevelToTwo()
        {
            // Arrange
            string name = "Character";
            Mage character = new Mage(name);
            int expected = 2;

            // Act
            character.LevelUp();
            int actual = character.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeMage_ShouldCreateMageWithProperDefaultAttributes()
        {
            // Arrange
            Mage mage;
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 1),
                                                     new Attribute(AttributeType.dexterity, 1),
                                                     new Attribute(AttributeType.intelligence, 8));

            // Act
            mage = new Mage("Mage");
            AttributeSet actual = mage.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_CallOnMage_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Mage mage = new Mage("Mage");
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 1+1),
                                                     new Attribute(AttributeType.dexterity, 1+1),
                                                     new Attribute(AttributeType.intelligence, 8+5));

            // Act
            mage.LevelUp();
            AttributeSet actual = mage.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeRanger_ShouldCreateMageWithProperDefaultAttributes()
        {
            // Arrange
            Ranger ranger;
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 1),
                                                     new Attribute(AttributeType.dexterity, 7),
                                                     new Attribute(AttributeType.intelligence, 1));

            // Act
            ranger = new Ranger("Ranger");
            AttributeSet actual = ranger.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_CallOnRanger_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Ranger ranger = new Ranger("Ranger");
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 1 + 1),
                                                     new Attribute(AttributeType.dexterity, 7 + 5),
                                                     new Attribute(AttributeType.intelligence, 1 + 1));

            // Act
            ranger.LevelUp();
            AttributeSet actual = ranger.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeRogue_ShouldCreateRogueWithProperDefaultAttributes()
        {
            // Arrange
            Rogue rogue;
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 2),
                                                     new Attribute(AttributeType.dexterity, 6),
                                                     new Attribute(AttributeType.intelligence, 1));

            // Act
            rogue = new Rogue("Rogue");
            AttributeSet actual = rogue.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_CallOnRogue_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Rogue rogue = new Rogue("Rogue");
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 2 + 1),
                                                     new Attribute(AttributeType.dexterity, 6 + 4),
                                                     new Attribute(AttributeType.intelligence, 1 + 1));

            // Act
            rogue.LevelUp();
            AttributeSet actual = rogue.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_InitializeWarrior_ShouldCreateWarriorWithProperDefaultAttributes()
        {
            // Arrange
            Warrior warrior;
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 5),
                                                     new Attribute(AttributeType.dexterity, 2),
                                                     new Attribute(AttributeType.intelligence, 1));

            // Act
            warrior = new Warrior("Warrior");
            AttributeSet actual = warrior.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_CallOnWarrior_ShouldIncreaseAttributesAppropriately()
        {
            // Arrange
            Warrior warrior = new Warrior("Warrior");
            AttributeSet expected = new AttributeSet(new Attribute(AttributeType.strength, 5 + 3),
                                                     new Attribute(AttributeType.dexterity, 2 + 2),
                                                     new Attribute(AttributeType.intelligence, 1 + 1));

            // Act
            warrior.LevelUp();
            AttributeSet actual = warrior.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
