using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CombinedFilter.combinedFilter(input);
            // results from running total 4, 6, 14, 17, 26, 30, 40, 45, 56, 62
            // fed into xor
            int[] expected = { 17, 19, 27, 4, 15, 11, 61, 56, 45, 43 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

