using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVuelingXUnit.Unit.Tests
{
    public class CalculadoraTests : IClassFixture<CalculadoraFixture>
    {
        CalculadoraFixture fixture;

        public CalculadoraTests(CalculadoraFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(2, fixture.MockObject.Division(4, 2));
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.Equal(44, fixture.MockObject.Division(2, 2));
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(2, fixture.MockObject.Division(4, 2));
        }

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(4, fixture.MockObject.Division(2, 2));
        }

        [Fact]
        public void SumaErrorTest()
        {
            Assert.Equal(5, fixture.MockObject.Division(2, 2));
        }
    }
}
