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
            AttributeSet expected = new AttributeSet(new Attribute(Attribute.attributeType.strength, 1),
                                                     new Attribute(Attribute.attributeType.dexterity, 1),
                                                     new Attribute(Attribute.attributeType.intelligence, 8));

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
            AttributeSet expected = new AttributeSet(new Attribute(Attribute.attributeType.strength, 1+1),
                                                     new Attribute(Attribute.attributeType.dexterity, 1+1),
                                                     new Attribute(Attribute.attributeType.intelligence, 8+5));

            // Act
            mage.LevelUp();
            AttributeSet actual = mage.BaseAttributes;

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
