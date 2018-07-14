using NMock;  //Nmock3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PooVuelingXUnit.Unit.Tests
{
    public class CalculadoraFixture
    {
        private MockFactory _factory = new MockFactory();

        public CalculadoraFixture()
        {
            var mock = _factory.CreateMock<ICalculadora>();
            mock.Expects.One.MethodWith(_ => _.Division(4, 2)).WillReturn((2));
            mock.Expects.One.MethodWith(_ => _.Multiplicacion(4, 2)).WillReturn((8));
            mock.Expects.One.MethodWith(_ => _.Resta(4, 2)).WillReturn((2));
            mock.Expects.One.MethodWith(_ => _.Suma(4, 2)).WillReturn((6));
            MockObject = mock.MockObject;

        }
        public ICalculadora MockObject { get; private set; }
    }
}
