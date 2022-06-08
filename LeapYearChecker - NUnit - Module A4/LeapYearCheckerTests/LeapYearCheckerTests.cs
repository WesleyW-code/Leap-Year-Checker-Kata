using FluentAssertions;
using NUnit.Framework;

namespace LeapYearCheckerTests
{
    [TestFixture]
    public class LeapYearCheckerTests
    {
        [Test]
        public void IsLeapYear_GivenALeapYear_WhenDivisibleBy400_ShouldReturnTrue()
        {
            // ARRANGE
            var year = 2000;
            var sut = CreateSut();

            // ACT
            var result = sut.IsLeapYear(year);

            // ASSERT
            result.Should().BeTrue();
        }

        [Test] 
        public void IsLeapYear_GivenANonLeapYear_WhenDivisibleBy100ButNotBy400_ShouldReturnFalse()
        {
            // ARRANGE
            var year = 100;
            var sut = CreateSut();

            // ACT
            var result = sut.IsLeapYear(year);

            // ASSERT
            result.Should().BeFalse();
        }

        [Test]
        public void IsLeapYear_GivenALeapYear_WhenDivisibleBy4ButNotBy100_ShouldReturnTrue()
        {
            // ARRANGE
            var year = 4;
            var sut = CreateSut();

            // ACT
            var result = sut.IsLeapYear(year);

            // ASSERT
            result.Should().BeTrue();
        }

        private LeapYearChecker.LeapYearChecker CreateSut()
        {
            return new LeapYearChecker.LeapYearChecker();
        }
    }
     
}