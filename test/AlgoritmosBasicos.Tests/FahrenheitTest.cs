using Xunit;

namespace AlgoritmosBasicos.Tests
{
    public class FahrenheitTest
    {

        [Theory]
        [InlineData(-30,-22)]
        [InlineData(-10,14)]
        [InlineData(0, 32)]
        [InlineData(20, 68)]
        [InlineData(30, 86)]
        public void ConvertirCelciusFarenheit(decimal celsius, decimal esperado)
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            var resultado = fahrenheit.CelsiusToFahrenheit(celsius);
            Assert.Equal(esperado, resultado);
        }
    }
}
