using System;
// Perfect Number

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i < num; i++)
        {
            if(num%i==0)
            {
                sum = sum + i;
            }
        }
        if(sum == num)
        {
            Console.WriteLine("Entered number is Perfect Number " + sum);
        }
        else
        {
            Console.WriteLine("Entered number not Perfect number "+sum);
        }
    }
}