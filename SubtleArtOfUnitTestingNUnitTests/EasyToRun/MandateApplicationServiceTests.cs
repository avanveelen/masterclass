using System;
using NSubstitute;
using NUnit.Framework;
using Shouldly;
using SubtleArtOfUnitTesting.EasyToWrite;
using TestHelpers;

namespace SubtleArtOfUnitTestingNUnitTests.EasyToRun
{
    [TestFixture]
    public class MandateApplicationServiceTests
    {

        private readonly IMandateRepository _mandateRepository = Substitute.For<IMandateRepository>();

        [Test]
        public void RemoveMandate_0MandateIsInActive_RemovesMandate()
        {
            // Arrange
            var service = new MandateApplicationService(this._mandateRepository);
            this._mandateRepository.Get(Arg.Any<Guid>()).Returns(ObjectMother.FutureMandate);
            var id = Guid.NewGuid();

            // Act
            service.RemoveMandate(id);

            // Assert
            _mandateRepository.Received(1).Remove(Arg.Any<Guid>());
        }

        [Test]
        public void RemoveMandate_1MandateIsActive_ThrowsException()
        {
            // Arrange
            var service = new MandateApplicationService(this._mandateRepository);
            this._mandateRepository.Get(Arg.Any<Guid>()).Returns(ObjectMother.ActiveMandate);
            var id = Guid.NewGuid();

            // Act
            var exception = Assert.Throws<InvalidOperationException>(() => service.RemoveMandate(id));

            // Assert
            exception.ShouldBeOfType<InvalidOperationException>();
            _mandateRepository.DidNotReceive().Remove(Arg.Any<Guid>());
        }
    }
}