using System;
using System.Linq;

public static class DifferenceOfSquares
{
    private static int Square(this int i) => i * i;

    public static int CalculateSquareOfSum(int max) => Enumerable.Range(1, max).Sum().Square();

    public static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Sum(i => i.Square());

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}