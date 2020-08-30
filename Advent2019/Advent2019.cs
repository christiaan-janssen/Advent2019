using System;
using System.IO;
using System.Linq;

namespace Advent2019NS
{
    class Advent2019
    {
        static readonly string input_file01 = "C:\\Users\\chris\\source\\repos\\Advent2019\\Advent2019\\Input\\Input01.txt";
        static readonly string input_file02 = "C:\\Users\\chris\\source\\repos\\Advent2019\\Advent2019\\Input\\Input02.txt";

        static void Main(string[] args)
        {
            /// Day One
            string[] inputData = File.ReadAllLines(input_file01);

            Day01 day01 = new Day01();
            Console.WriteLine("Day 01 - A: {0:G}", day01.calculateTotalMass(inputData));
            var total_fuel = inputData.Select(f => day01.calculateFuelForFuelForMass(Int32.Parse(f))).Sum();
            Console.WriteLine("Day 01 - B: {0:G}", total_fuel);

            /// Day Two
            Intcode computer = new Intcode();
            string inputProgram = File.ReadAllText(input_file02);
            string[] parsedInput = inputProgram.Split(",");
            int[] program = Array.ConvertAll(parsedInput, Int32.Parse);

            program[1] = 12;
            program[2] = 2;

            int output = computer.run(program);
            Console.WriteLine("Day 02 - A: {0:G}", output);

        }
    }
}
