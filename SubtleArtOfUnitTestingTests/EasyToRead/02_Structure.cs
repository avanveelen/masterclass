using SubtleArtOfUnitTesting;

using Xunit;

namespace SubtleArtOfUnitTestingTests.EasyToRead
{
    public class Structure
    {
        [Fact]
        public void IsValid_GivenEmailAddressIsEmpty_ReturnsFalse()
        {
            Assert.False(new EmailValidator().IsValid(string.Empty));
        }


        [Fact]
        public void IsValid_GivenEmailAddressIsEmpty_ReturnsFalse_2()
        {
            // Arrange
            var emailAddress = string.Empty;
            var validator = new EmailValidator();

            // Act
            var result = validator.IsValid(emailAddress);

            // Assert
            Assert.False(result);
        }
    }
}