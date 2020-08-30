using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2019NS
{
    public class Day01
    {
        public int calculateMass(int mass) => Math.Max(0, mass / 3 - 2);

        public int calculateFuelForFuelForMass (int mass, int fuel=0)
        {
            if (mass <= 0) { return fuel; }

            int extra_fuel = calculateMass(mass);
            return calculateFuelForFuelForMass(extra_fuel, fuel + extra_fuel);

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
