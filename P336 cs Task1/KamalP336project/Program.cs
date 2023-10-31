using System;
class Program
{
    public static int f(int a)
    {
        return a * a;
    }
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(f(a));
    }
}
