using System;
using System.Collections.Generic;
using System.Threading.Tasks; // to perform multiple operations
using System.Text;
using System.Linq;
// coupon code problem


 class Temp
{
    public static void Temp_Coversion()
    {
        Console.WriteLine("Please Select  any Choice");
        Console.Write("1.Celcius to Fahrenheit  2.Fahrenheit to Celcius ");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                Console.WriteLine("Enter the temperature in celcius");
                double c = Convert.ToDouble(Console.ReadLine());
                double f = (c * 9 / 5) + 32;
                Console.WriteLine("Temperature in Fahrenheit=" + f);
                break;
            case 2:
                Console.WriteLine("Enter the temperature in Fahrenheit");
                double fr = Convert.ToDouble(Console.ReadLine());
                double cel = (fr - 32) * 9 / 5;
                Console.WriteLine("Temperature in Celcius=" + cel);
                break;
        }


    }
}


class Program
{
    static void Main(string[] args)
    {
        Temp.Temp_Coversion();
    }
}   
    
