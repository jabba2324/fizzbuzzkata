using System;
using FizzBuzz.Extensions;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string PlayTurn(int input)
        {
            if (input.IsMultipleOf(3) && input.IsMultipleOf(5))
            {
                return "FizzBuzz";
            } 
            
            if(input.IsMultipleOf(3))
            {
                return "Fizz";
            }
             
            return input.IsMultipleOf(5) ? "Buzz" : input.ToString();
        }
    }
}