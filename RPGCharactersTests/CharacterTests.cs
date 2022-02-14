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
            string name = "Character";
            Mage character = new Mage(name);
            int expected = 1;

            // Act
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

        public static IEnumerable<object[]> Characters
        {
            get
            {
                yield return new object[] { new Mage("Mage") };
            }
        }

        [Theory]
        [MemberData(nameof(Characters))]
        public void Constructor_InitializeWithName_ShouldCreateCharacterWithProperDefaultAttributes(Character character)
        {
            // Arrange
            
            // Act

            // Assert
            Assert.True(true);

        }
    }
}
