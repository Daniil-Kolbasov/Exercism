using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
        Enumerable.Range(1, max -1)
        .Where(i => multiples.Any(v => (v != 0) && i % v == 0))
        .Sum();
}