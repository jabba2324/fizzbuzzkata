using System;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string PlayTurn(int input)
        {
            if (((input % 3) == 0) && ((input % 5) == 0))
            {
                return "FizzBuzz";
            }else if((input % 3) == 0)
            {
                return "Fizz";
            }
            else if((input % 5) == 0) {
                return "Buzz";
            }else{
                return input.ToString();
            }
        }
    }
}