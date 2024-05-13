using System;
using RSM.HCD.CSharp.Core.Tests.Stubs;
using RSM.HCD.CSharp.Core.Tests.Unit;
using RSM.HCD.CSharp.Testing;
using RSM.HCD.CSharp.Testing.Tests;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace RSM.HCD.CSharp.Core.Tests.Models.Entities
{
    public class LockableTest : CoreUnitTest
    {
        #region Setup

        public LockableTest(ITestOutputHelper output) : base(output)
        {
        }

        #endregion Setup

        #region IsLocked

        [Fact]
        public void IsLocked_When_LockedUntil_IsNull_Then_Returns_False()
        {
            // Arrange
            var sut = new LockableEntity();

            // Act & Assert
            sut.IsLocked.ShouldBeFalse();
        }

        [Fact]
        public void IsLocked_When_LockedUntil_IsNotNull_And_IsGreaterThan_The_CurrentTime_Then_Returns_True()
        {
            // Arrange
            var sut = new LockableEntity { LockedUntil = DateTimeOffset.Now.AddMinutes(15) };

            // Act & Assert
            sut.IsLocked.ShouldBeTrue();
        }

        [Fact]
        public void IsLocked_When_LockedUntil_IsNotNull_And_IsLessThan_CurrentTime_Then_Returns_False()
        {
            // Arrange
            var sut = new LockableEntity { LockedUntil = DateTimeOffset.Now.AddMinutes(-15) };

            // Act & Assert
            sut.IsLocked.ShouldBeFalse();
        }

        #endregion IsLocked
    }
}
