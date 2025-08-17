using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FizzBuzz.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : Controller
    {
        IFizzBuzzService fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            this.fizzBuzzService = fizzBuzzService;
        }

        [HttpGet("{number}")]
        public string Get(int number)
        {
            return fizzBuzzService.PlayTurn(number);
        }
    }
}
