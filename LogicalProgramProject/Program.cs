using System;
// Prime Number


class Prime
{
    public static int Logic(int a)
    {
        int i;
        for( i = 2; i <= a-1;i++)
        {
            if(a%i == 0)
            {
                return 0;
            }
        }
        if(i == a)
        {
            return 1;
        }
        return 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int res=Prime.Logic(num);
        if(res == 0)
        {
            Console.WriteLine("{0} is not a prime nuber", num);
        }
        else
        {
            Console.WriteLine("{0} is a prime number", num);
        }
    }
}