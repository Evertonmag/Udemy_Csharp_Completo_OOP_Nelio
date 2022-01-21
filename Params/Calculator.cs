using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Calculator
    {
        #region Params
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        #endregion

        #region Modificadores
        // ref
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        // out
        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
        #endregion

    }
}
