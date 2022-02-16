using RPGCharacters;
using Xunit;

namespace RPGCharactersTests
{
    public class ItemTests
    {
        Warrior testWarrior = new Warrior("Warrior");
        Weapon testAxe = new Weapon("Common axe", 1, WeaponType.Axe, 7.0, 1.1);
        Armor testPlateBody = new Armor("Common plate body armor", 1, Slot.Body, ArmorType.Plate, new AttributeSet(1, 0, 0));
        Weapon testBow = new Weapon("Common bow", 1, WeaponType.Bow, 12.0, 0.8);
        Armor testClothHead = new Armor("Common cloth head armor", 1, Slot.Head, ArmorType.Cloth, new AttributeSet(0, 0, 5));

        [Fact]
        public void EquipItem_CallOnWeaponWithTooHighRequirement_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            testAxe = new Weapon("Common axe", 2, WeaponType.Axe, 7.0, 1.1);

            // Act & Assert
            Assert.Throws<InvalidWeaponException>((() => testWarrior.EquipItem(testAxe)));
        }

        [Fact]
        public void EquipItem_CallOnArmorWithTooHighRequirement_ShouldThrowInvalidArmorException()
        {
            // Arrange
            testPlateBody = new Armor("Common plate body armor", 2, Slot.Body, ArmorType.Plate, new AttributeSet(1, 0, 0));

            // Act & Assert
            Assert.Throws<InvalidArmorException>((() => testWarrior.EquipItem(testPlateBody)));
        }

        [Fact]
        public void EquipItem_CallOnWrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Act & Assert
            Assert.Throws<InvalidWeaponException>((() => testWarrior.EquipItem(testBow)));
        }

        [Fact]
        public void EquipItem_CallOnWrongArmorType_ShouldThrowInvalidArmorException()
        {
            // Act & Assert
            Assert.Throws<InvalidArmorException>((() => testWarrior.EquipItem(testClothHead)));
        }

        [Fact]
        public void EquipItem_CallOnValidWeapon_ShouldReturnSuccessMessage()
        {
            // Arrange
            string expected = "New weapon equipped!";

            // Act
            string actual = testWarrior.EquipItem(testAxe);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EquipItem_CallOnValidArmor_ShouldReturnSuccessMessage()
        {
            // Arrange
            string expected = "New armor equipped!";

            // Act
            string actual = testWarrior.EquipItem(testPlateBody);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CallOnCharacterWithNoWeapon_ShouldReturnUnarmedDamage()
        {
            // Arrange
            double expected = 1 * (1 + (5.0 / 100.0));

            // Act
            double actual = testWarrior.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CallOnCharacterWithWeapon_ShouldReturnDamage()
        {
            // Arrange
            testWarrior.EquipItem(testAxe);
            double expected = (7 * 1.1) * (1 + (5.0 / 100.0));


            // Act
            double actual = testWarrior.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CallOnCharacterWithWeaponAndArmor_ShouldReturnDamage()
        {
            // Arrange
            testWarrior.EquipItem(testAxe);
            testWarrior.EquipItem(testPlateBody);
            double expected = (7 * 1.1) * (1 + ((5.0 + 1.0) / 100.0));

            // Act
            double actual = testWarrior.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
