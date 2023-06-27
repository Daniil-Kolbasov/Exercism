using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double f = Math.Pow(x, 2) + Math.Pow(y, 2);
        if (f <= 1)
            return 10;
        if (f <= 25)
            return 5;
        if (f <= 100)
            return 1;
        return 0;
    }
}
