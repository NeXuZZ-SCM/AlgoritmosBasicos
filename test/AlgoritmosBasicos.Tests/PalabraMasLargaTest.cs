using Xunit;

namespace AlgoritmosBasicos.Tests
{
    public class PalabraMasLargaTest
    {
        [Theory]
        [InlineData("Yo en realidad no tengo nada que ver conmigo mismo ...", 8)]
        [InlineData("Mi diagnóstico es sencillo, sé que no tengo remedio", 11)]
        [InlineData("Somos pobres de verdad, pero no de voluntad.", 9)]
        [InlineData("Los cronopios… dejan los recuerdos sueltos por la casa", 12)]

        public void EncuentraPalabraLargaTest(string frase, int longitud)
        {
            var buscar = new PalabraMasLarga();
            var resultado = buscar.EncuentraPalabraLarga(frase);
            Assert.Equal(longitud, resultado);
        }
    }
}
