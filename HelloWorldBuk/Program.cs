//C# Sharp LINQ - 3

using System.Linq;
using System;
using System.Collections.Generic;


int[] numbers = new int[] { 5, 2, 8, 9, 5, 3, 1, 4, 4, 5, 2, 3, 0, 2, 9, 1, 6 };

var ans = from number in numbers
          let sqr = number * number
          select new {number,sqr};
 

foreach (var n in ans)
{
    Console.WriteLine($"number: {n.number} square:{n.sqr} ");
}