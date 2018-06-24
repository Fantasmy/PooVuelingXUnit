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
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(2, Divide(4, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(3, Divide(4, 2));
        }

        int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
