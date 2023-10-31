using System;
class Program
{
    public static double CircleArea(double r)
    {
        double pi = 3;
        return pi * r * r;
    }
    public static double RectangleArea(double a, double b)
    {
        return a + b;
    }
    public static double TringleInscribedInCircle(double a, double b, double c, double r)
    {
        double p = (a+b+c)/2;
        return p*r;
    }
}