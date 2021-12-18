using System;
// Fibonacci Series.

class Fibb
{
    public static int FibCal(int n)
    {
        int a = 0;
        int b = 1;
        for(int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int p = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < p; i++)
        {
            Console.Write("{0} ",Fibb.FibCal(i));
        }
    }
}