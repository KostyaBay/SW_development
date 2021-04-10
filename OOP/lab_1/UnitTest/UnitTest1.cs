using System;
using NSubstitute;
using Xunit;

namespace UnitTest
{ 

    public class UnitTest1
    {
        private ILogger loggerStub = Substitute.For<ILogger>(); //заглушка для создания интерфейса

        [Fact]
        public void TestForDerivSin()
        {
            var loggerMock = Substitute.For<ILogger>(); //заглушка для создания интерфейса
            var calculator = new Calculator(loggerStub); //ARRANGE
            var result = calculator.deriv_sin(0); //ACT
            var expected = 1;
            Assert.Equal(expected, result); //ASSERT
        }

        [Fact]
        public void TestForDerivCos()
        {
            var calculator = new Calculator(loggerStub);
            var result = calculator.deriv_cos(0);
            var expected = -0;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestForDerivExp()
        {
            var calculator = new Calculator(loggerStub);
            var result = calculator.deriv_exp(0);
            var expected = 1;
            Assert.Equal(expected, result);
        }
    }
}
