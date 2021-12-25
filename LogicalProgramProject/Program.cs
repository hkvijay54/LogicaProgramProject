using System;
using System.Collections.Generic;
using System.Threading.Tasks; // to perform multiple operations
using System.Text;
using System.Linq;
// coupon code problem


class MonthlyPayment
{
    public static void MonthlyInstallment(int p, int y, int R)
    {
        //Console.Out.Write("\n Lone Ammount : " + p);
        //Console.Out.Write("\n Monthly intrast rate : " + R);
        //Console.Out.Write("\n Number of Monthly instalment : " + y);
        double val = Convert.ToDouble(Math.Pow((1 + R), y));

        double payment = Convert.ToDouble(R * val * p / (val - 1));


        Console.Out.Write("\n Ammount paid back : " + payment * y);
        Console.Out.Write("\n Intrast Ammount : " + ((payment * y) - p));
        Console.Out.Write("\n Monthly Payment : " + (payment));

    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Out.Write("\n Lone Ammount : ");
        int loan = Convert.ToInt32(Console.ReadLine());
        Console.Out.Write("\n Monthly intrast rate : ");
        int interest = Convert.ToInt32(Console.ReadLine());
        Console.Out.Write("\n Number of Monthly instalment : ");
        int no_Of_Install = Convert.ToInt32(Console.ReadLine());

        MonthlyPayment.MonthlyInstallment(loan, interest, no_Of_Install);
    }
}   
    
