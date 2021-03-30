using System;

namespace Lib
{
    public static class FactorialNumber
    {
        public static int GenerateFactorialNumber(int number) => (number == 1) ? 1 : number * GenerateFactorialNumber(number - 1);
    }
}
