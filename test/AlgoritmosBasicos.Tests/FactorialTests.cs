using Xunit;

namespace AlgoritmosBasicos.Tests
{
    public class FactorialTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(6, 720)]
        [InlineData(10, 3628800)]
        [InlineData(20, 2432902008176640000)]
      
        public void CalculaFactorialTest(long entrada, long esperado)
        {
            var factorial = new Factorial();
            var resultado = factorial.CalculaFactorial(entrada);
            Assert.Equal(esperado, resultado);
        }
    }
}
