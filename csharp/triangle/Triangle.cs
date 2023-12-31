using System;
using System.Reflection.Metadata.Ecma335;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (IsTriangel(side1, side2, side3))
            return side1 != side2 && side2 != side3 && side3 != side1;
        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        if (IsTriangel(side1, side2, side3))
            return side1 == side2 || side2 == side3 || side3 == side1;
        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        if (IsTriangel(side1, side2, side3))
            return side1 == side2 && side2 == side3;
        return false;
    }

    private static bool IsTriangel(double side1, double side2, double side3)
    {
        if (side1 == 0 || side2 == 0 || side3 == 0)
            return false;
        if (side1 >= side2 + side3 || side2 >= side1 + side3 || side3 >= side1 + side2)
            return false;
        return true;
    }
}