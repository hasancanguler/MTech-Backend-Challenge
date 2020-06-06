using System;
using System.Collections.Generic;
using System.Text;

namespace MTechBuss.ArrayService
{
    public class Order : IOrder
    {
        public int[] Reverse(int[] array)
        {
            int[] reverseArr = new int[array.Length];
            double limit = ((double)array.Length / 2) ;

            for (int index = 0; index < limit ; index++)
            {
                reverseArr[index] = array[array.Length -1  - index];

                reverseArr[array.Length - 1 - index] = array[index];
            }

            return reverseArr;
        }
    }
}
