using System;
using FizzBuzz.Interfaces;
using FizzBuzz.Services;
using Xunit; 

namespace FizzBuzzApi.Tests
{ 
    public class FizzBuzzServiceTest
    {
        IFizzBuzzService fizzBuzzService = new FizzBuzzService();
        int input = 0;
        string output = "";

        [Fact]
        public void NumberSixReturnsFizz()
        {
            GivenTheNumberSixIsInput();
            WhenNumberIsPlayed();
            ThenFizzIsReturned();
        }

        [Fact]
        public void NumberNineReturnsFizz()
        {
            GivenTheNumberNineIsInput();
            WhenNumberIsPlayed();
            ThenFizzIsReturned();
        }

        [Fact]
        public void RandomNumberDivisibleByThreeReturnsFizz()
        {
            GivenRandomNumberDivisibleByThree();
            WhenNumberIsPlayed();
            ThenFizzIsReturned();
        }

        [Fact]
        public void RandomNumberDivisibleByFiveReturnsBuzz()
        {
            GivenRandomNumberDivisibleByFive();
            WhenNumberIsPlayed();
            ThenBuzzIsReturned();
        }

        private void GivenRandomNumberDivisibleByFive()
        {
            var random = new Random();

            var newInput = (random.Next(0, 300) * 5);

            if(newInput % 3 == 0)
            {
                GivenRandomNumberDivisibleByFive();
            }else{
                input = newInput;
            }
        }

        private void GivenRandomNumberDivisibleByThree()
        {
            var random = new Random();

            var newInput = (random.Next(0,300) * 3);

            if (newInput % 5 == 0)
            {
                GivenRandomNumberDivisibleByThree();
            }
            else
            {
                input = newInput;
            }
        }

        private void GivenTheNumberNineIsInput()
        {
            input = 9;
        }

        private void ThenFizzIsReturned()
        {
            Assert.Equal("Fizz",output);
        }

        private void WhenNumberIsPlayed()
        {
            output = fizzBuzzService.PlayTurn(input);
        }

        private void GivenTheNumberSixIsInput()
        {
            input = 6;
        }

        [Fact]
        public void NumberTenReturnsBuzz()
        {
            GivenTheNumberTenIsInput();
            WhenNumberIsPlayed();
            ThenBuzzIsReturned();
        }

        private void ThenBuzzIsReturned()
        {
            Assert.Equal("Buzz", output);
        }

        private void GivenTheNumberTenIsInput()
        {
            input = 10;
        }

        [Fact]
        public void RandomNumberDivisibleByThreeAndFiveReturnsFizzBuzz()
        {
            GivenRandomNumberDivisibleByThreeAndFive();
            WhenNumberIsPlayed();
            ThenFizzAndBuzzIsReturned();
        }

        private void ThenFizzAndBuzzIsReturned()
        {
            Assert.Equal("FizzBuzz", output);
        }

        private void GivenRandomNumberDivisibleByThreeAndFive()
        {
            var random = new Random();

            input = (random.Next(0,300) * 15);
        }

        [Fact]
        public void NumberNeitherDivisibleByThreeOrFiveReturnsItself()
        {
            GivenRandomNumberNotDivisibleByThreeOrFive();
            WhenNumberIsPlayed();
            ThenNumberIsReturned();
        }

        private void ThenNumberIsReturned()
        {
            Assert.Equal(input.ToString(),output);
        }

        private void GivenRandomNumberNotDivisibleByThreeOrFive()
        {
            var random = new Random();
            var newInput = random.Next(0,300);

            if(((newInput % 3) == 0) || ((newInput % 5) == 0))
            {
                GivenRandomNumberNotDivisibleByThreeOrFive();
            }else{
                input = newInput;
            }
        }
    }
}
