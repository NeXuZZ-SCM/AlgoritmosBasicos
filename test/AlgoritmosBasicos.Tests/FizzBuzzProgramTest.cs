using Xunit;

namespace AlgoritmosBasicos.Tests
{
    public class FizzBuzzProgramTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(97, "97")]
        [InlineData(100, "Buzz")]
        [InlineData(15, "FizzBuzz")]

        public void FizzBuzzTest(int numerp, string valorEsperado)
        {
            var fizzBuzz = new FizzBuzzProgram();
            var resultado = fizzBuzz.FizzBuzz(numerp);
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
