using System;
using System.IO;
using System.Linq;

namespace Advent2019NS
{
    class Advent2019
    {
        static readonly string input_file01 = "C:\\Users\\chris\\source\\repos\\Advent2019\\Advent2019\\Input\\Input01.txt";

        static void Main(string[] args)
        {
            string[] inputData = File.ReadAllLines(input_file01);

            Day01 day01 = new Day01();
            Console.WriteLine("Day 01 - A: {0:G}", day01.calculateTotalMass(inputData));
        }
    }
}
