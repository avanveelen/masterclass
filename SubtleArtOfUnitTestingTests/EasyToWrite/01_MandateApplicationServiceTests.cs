using System;

using NSubstitute;

using Shouldly;

using SubtleArtOfUnitTesting.EasyToWrite;
using TestHelpers;
using Xunit;

namespace SubtleArtOfUnitTestingTests.EasyToWrite
{
    public class MandateApplicationServiceTests
    {
        private readonly IMandateRepository _mandateRepository = Substitute.For<IMandateRepository>();
       
        [Fact]
        public void RemoveMandate_MandateIsActive_ThrowsException()
        {
            // Arrange
            var service = new MandateApplicationService(this._mandateRepository);
            this._mandateRepository.Get(Arg.Any<Guid>()).Returns(ObjectMother.ActiveMandate);
            var id = Guid.NewGuid();

            // Act
            var exception = Record.Exception(() => service.RemoveMandate(id));

            // Assert
            exception.ShouldBeOfType<InvalidOperationException>();
            _mandateRepository.DidNotReceive().Remove(Arg.Any<Guid>());
        }
    }
}