using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PooVuelingXUnit.Integration.Tests
{
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(3, iCalculadora.Division(9, 3));
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.Equal(9, iCalculadora.Division(3, 3));
        }

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(4, iCalculadora.Division(2, 2));
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(3, iCalculadora.Division(8, 5));
        }
    }
}
