using System;
using System.Collections.Generic;
using Bogus;
using SubtleArtOfUnitTesting.Financial;
using TestHelpers;
using Xunit;

namespace SubtleArtOfUnitTestingTests.EasyToRead
{
    public class MinimalPassing
    {
        [Fact]
        public void IsActive_MandateStartDateIsInTheFuture_ReturnsFalse()
        {
            // Arrange
            var mandate = new RebalancingMandate(
                "Client X Mandate 2022",
                "Mandate for the new 2022 rules.",
                new Dictionary<string, decimal>
                {
                    ["private equity"] = 0.5m,
                    ["Equity world wide"] = 0.75m,
                    ["emerging markets"] = 0.25m,
                    ["developed markets"] = 0.10m
                },
                new DateTime(2022, 01, 01));

            // Act
            var result = mandate.IsActive();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsActive_MandateStartDateIsInTheFuture_ReturnsFalse_2()
        {
            // Arrange
            var mandate = ObjectMother.FutureMandate;

            // Act
            var result = mandate.IsActive();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsActive_MandateStartDateIsInTheFuture_ReturnsFalse_3()
        {
            // Arrange
            var mandate = ObjectMother.Mandate
                .WithStartDate(new DateTime(2022, 01, 01))
                .Build();

            // Act
            var result = mandate.IsActive();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsActive_MandateStartDateIsInTheFuture_ReturnsFalse_4()
        {
            // Arrange
            var faker = new Faker();
            var mandate = ObjectMother.Mandate
                .WithStartDate(faker.Date.Future())
                .Build();

            // Act
            var result = mandate.IsActive();

            // Assert
            Assert.False(result);
        }
    }
}