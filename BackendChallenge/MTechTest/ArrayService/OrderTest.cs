using MTechBuss.ArrayService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTechTest.ArrayService
{

    public class OrderTest
    {
        Order arrayOrder = new Order();
        [Test]
        public void Reverse()
        {
            int[] testArr = { 1, 4, 6, 9 };
            int[] resultArr = { 9, 6, 4, 1 };

            int[] controlArr = arrayOrder.Reverse(testArr);

            CollectionAssert.AreEqual(resultArr, controlArr);
        }

        [Test]
        public void ReverseOdd()
        {
            int[] testArr = { 1, 4, 6,};
            int[] resultArr = { 6, 4, 1 };

            int[] controlArr = arrayOrder.Reverse(testArr);

            CollectionAssert.AreEqual(resultArr, controlArr);
        }
    }
}
