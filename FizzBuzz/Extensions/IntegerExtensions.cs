namespace FizzBuzz.Extensions
{
    public static class IntegerExtensions
    {
        public static bool IsMultipleOf(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}