using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2019NS
{
    public class Intcode
    {
        public int[] program;

        public int run(int[] prog)
        {
            program = prog;
            bool running = true;
            int stackPtr = 0;
            int instruction, op1, op2, result;

            while(running)
            {
                instruction = program[stackPtr];
                if (instruction == 99)
                {
                    running = false;
                    break;
                }

                op1 = program[stackPtr+1];
                op2 = program[stackPtr+2];
                result = program[stackPtr+3];

                switch (instruction)
                {
                    case 1:
                        // Add
                        program[result] = program[op1] + program[op2];
                        break;
                    case 2:
                        // Multiply
                        program[result] = program[op1] * program[op2];
                        break;
                    case 99:
                        // Exit
                        running = false;
                        break;
                    default:
                        break;
                }

                stackPtr += 4;
            }
            return program[0];

        }
    }
}
