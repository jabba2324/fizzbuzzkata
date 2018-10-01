using System;
using FizzBuzz.Services;
using FizzBuzzApi.Controllers;
using Xunit;

namespace FizzBuzzTests.Tests
{
    public class FizzBuzzControllerTest
    {
        FizzBuzzController fizzBuzzController = new FizzBuzzController(new FizzBuzzService());
        int input;
        string response;

        [Fact]
        public void IntegerReturnsIntergerResponse()
        {
            GivenIntegerUrlParameter();
            response = WhenGetIsCalled();
            ThenIntegerResponseIsReturned();
        }

        [Fact]
        public void FizzableIntegerReturnsFizz()
        {
            GivenFizzableInteger();
            response = WhenGetIsCalled();
            ThenFizzResponseIsReturned();
        }

        [Fact]
        public void BuzzableIntegerReturnsBuzz()
        {
            GivenBuzzableInteger();
            response = WhenGetIsCalled();
            ThenBuzzResponseIsReturned();
        }

        [Fact]
        public void FizzBuzzableIntegerReturnsFizzBuzz()
        {
            GivenFizzBuzzableInteger();
            response = WhenGetIsCalled();
            ThenBuzzResponseIsReturned();
            ThenFizzResponseIsReturned();
        }

        private void GivenFizzBuzzableInteger()
        {
            input = 15;
        }

        private void GivenBuzzableInteger()
        {
            input = 3;
        }

        private void ThenBuzzResponseIsReturned()
        {
            Assert.Contains("Fizz", response);
        }

        private void ThenFizzResponseIsReturned()
        {
            Assert.Contains("Buzz", response);
        }

        private void GivenFizzableInteger()
        {
            input = 5;
        }

        private void ThenIntegerResponseIsReturned()
        {
            Assert.Equal("1", response);
        }

        private string WhenGetIsCalled()
        {
            return fizzBuzzController.Get(input);
        }

        private void GivenIntegerUrlParameter()
        {
            input = 1;
        }
    }
}
