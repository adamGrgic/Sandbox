﻿using Microsoft.AspNetCore.Mvc;
using System.Runtime.ExceptionServices;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.zip?view=net-8.0

    // Use this method to merge two sequences

    [Route("[controller]/[action]")]
    public class Zip : Controller
    {
        public Zip()
        {

        }

        [HttpGet]
        public IActionResult V1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var strings = new List<string>() { "one", "two", "three", "four" };

            var zippedList = numbers.Zip(strings, (first, second) => $"{first}  {second}");

            return Ok(zippedList);

            // Expected result:
            // 1 one
            // 2 two
            // 3 three
            // 4 four
        }

        [HttpGet]
        public IActionResult V2()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var strings = new List<string>() { "one", "two", "three", "four" };
            var alphas = new List<char>() { 'A', 'B', 'C', 'D' };

            var zippedList = numbers.Zip(strings, alphas);

            return Ok(zippedList);

            // Expected Result: 
            // {1, "one", 'A'}
            // {2, "two", 'B'}
            // {3, "three", 'C'}
            // {4, "four", 'D'}
        }


    }
}
