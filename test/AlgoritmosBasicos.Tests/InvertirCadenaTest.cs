using Xunit;

namespace AlgoritmosBasicos.Tests
{
    public class InvertirCadenaTest
    {
        [Theory]
        [InlineData("oso", "oso")]
        [InlineData("hola", "aloh")]
        [InlineData("yo Programo", "omargorP oy")]
        [InlineData("Omar", "ramO")]
        public void InvertirCadena(string entrada, string esperado)
        {
            var invertirCadena = new InvierteCadena();
            var resultado = invertirCadena.InvertirCadena(entrada);
            Assert.Equal(esperado, resultado);
        }
    }
}
