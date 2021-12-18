using System;
// Reverse a number



class Program
{
    static void Main(string[] args)
    {
        int num, temp, remainder, reverse = 0;
        Console.WriteLine("Enter an integer");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num /= 10;
        }
        Console.WriteLine("Given number is = {0}", temp);
        Console.WriteLine("Its reverse is = {0}", reverse);
    }
}