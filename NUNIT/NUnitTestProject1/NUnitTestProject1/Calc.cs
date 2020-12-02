using System;

namespace NUnitTestProject1
{
    public static class Calc
    {
        static public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        static public int Subtraction(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        static public int Multiply(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        static public int Partition(int operand1, int operand2)
        {
            if (operand2 == 0)
                return 0;
            return operand1 / operand2;
        }
    }
}
