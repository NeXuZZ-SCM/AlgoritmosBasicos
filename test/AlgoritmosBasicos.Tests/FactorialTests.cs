using Xunit;

namespace AlgoritmosBasicos.Tests
{
    public class FactorialTests
    {
        [Theory]
        [InlineData("oso", "oso")]
        [InlineData("hola", "aloh")]
        [InlineData("yo Programo", "omargorP oy")]
        public void InvertirCadena(string entrada, string esperado)
        {
            var invertirCadena = new InvierteCadena();
            var resultado = invertirCadena.InvertirCadena(entrada);
            Assert.Equal(esperado, resultado);
        }
    }
}
