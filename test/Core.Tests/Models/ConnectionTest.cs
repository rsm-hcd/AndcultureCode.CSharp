using System;
using RSM.HCD.CSharp.Core.Models;
using RSM.HCD.CSharp.Core.Tests.Stubs;
using RSM.HCD.CSharp.Core.Tests.Unit;
using RSM.HCD.CSharp.Testing;
using RSM.HCD.CSharp.Testing.Tests;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace RSM.HCD.CSharp.Core.Tests.Models
{
    public class ConnectionTest : CoreUnitTest
    {
        #region Setup

        public ConnectionTest(ITestOutputHelper output) : base(output)
        {
        }

        #endregion Setup

        #region ToString

        [Fact]
        public void ToString_Given_No_Parameters_When_Property_Null_Returns_Without_Property()
        {
            // Arrange
            var sut = Build<Connection>(e => e.Database = null);

            // Act
            var result = sut.ToString();

            // Assert
            result.ShouldNotBeEmpty();
            result.ToLower().ShouldNotContain("database");
        }

        [Fact]
        public void ToString_Given_No_Parameters_When_Property_EmptyString_Returns_Without_Property()
        {
            // Arrange
            var sut = Build<Connection>(e => e.Database = " ");

            // Act
            var result = sut.ToString();

            // Assert
            result.ShouldNotBeEmpty();
            result.ToLower().ShouldNotContain("database");
            result.ShouldNotContain("; ;");
        }

        [Fact]
        public void ToString_Given_No_Parameters_Returns_SemiColon_Delimited_List()
        {
            // Arrange
            var sut = Build<Connection>();

            // Act
            var result = sut.ToString();

            // Assert
            result.ShouldNotBeEmpty();
            result.ShouldContain(";");
            result.ShouldContain(sut.AdditionalParameters);
            result.ShouldContain(sut.Database);
            result.ShouldContain(sut.Datasource);
            result.ShouldContain(sut.Password);
            result.ShouldContain(sut.UserId);
        }

        [Fact]
        public void ToString_Given_Delimiter_Returns_Custom_Delimited_List()
        {
            // Arrange
            var expected = Random.String(1);
            var sut = Build<Connection>();

            // Act
            var result = sut.ToString(delimiter: expected);

            // Assert
            result.ShouldNotBeEmpty();
            result.ShouldContain(expected);
            result.ShouldContain(sut.AdditionalParameters);
            result.ShouldContain(sut.Database);
            result.ShouldContain(sut.Datasource);
            result.ShouldContain(sut.Password);
            result.ShouldContain(sut.UserId);
        }

        #endregion ToString
    }
}
