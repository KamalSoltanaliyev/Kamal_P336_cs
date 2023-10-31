using System;
class Program
{
    public static int f(int max)
    {
        int sum = 0;
        for (int i = 0; i < max; i++)
        {
            if(sum + i < max)
            {
                sum += i;
            }
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine(f(11));
    }
}