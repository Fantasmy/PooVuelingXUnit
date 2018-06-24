using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poVueling.XUnit.Tests
{
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 3)]
        public void DivisionTest(int num1, int num2, int result)
        {
            Assert.True(iCalculadora.Division(num1, num2) == result);
        }


    }
}
