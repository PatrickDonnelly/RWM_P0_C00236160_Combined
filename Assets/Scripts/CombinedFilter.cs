using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return xor21Filter.xor21Func(RunningTotal.runningTotals(xs));
    }
}

