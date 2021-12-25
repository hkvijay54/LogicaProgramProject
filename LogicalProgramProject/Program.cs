using System;
using System.Collections.Generic;
using System.Threading.Tasks; // to perform multiple operations
using System.Text;
using System.Linq;
// coupon code problem


 class Calender
{
    public static void Cal(int day, int month, int year)
    {
        if (month == 1)
        {
            month = 13;
            year--;
        }
        if (month == 2)
        {
            month = 14;
            year--;
        }
        int q = day;
        int m = month;
        int k = year % 100;
        int j = year / 100;
        int h = q + 13 * (m + 1) / 5 + k + k / 4 + j / 4 + 5 * j;
        h = h % 7;
        switch (h)
        {
            case 0:
                Console.WriteLine("Saturday");
                break;

            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            case 5:
                Console.WriteLine("Thursday");
                break;

            case 6:
                Console.WriteLine("Friday");
                break;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an Day: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an Month: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an Year: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Calender.Cal(d, m, y);


    }
}   
    
