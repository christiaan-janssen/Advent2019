using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2019NS
{
    public class Day01
    {
        public int calculateMass (int mass)
        {
            return mass / 3 - 2;
        }

        public int calculateTotalMass(string[] input)
        {
            int mass, totalMass = 0;

            foreach (string line in input)
            {
                mass = Int32.Parse(line);
                totalMass += calculateMass(mass);
            }

            return totalMass;
        }
    }
}
