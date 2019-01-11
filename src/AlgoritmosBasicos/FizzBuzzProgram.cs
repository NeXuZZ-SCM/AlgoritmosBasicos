namespace AlgoritmosBasicos
{
    public class FizzBuzzProgram
    {
        /// <summary>
        /// Recibe un número entrero positivo  y regresa:
        /// la palabra Fizz si el número es multiplo de 3
        /// la palabra Buzz si el número es multiplo de 5
        /// la palabra FizzBuzz si el número es multiplo de 3 y 5
        /// el numero  si no es multiplo de 3 y 5
        /// </summary>
        /// <param name="celsius">Indica el valor en grados celcius</param>
        /// <returns>decimal</returns>
        public string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString();
        }
    }
}
