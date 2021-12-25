using System;
using System.Collections.Generic;
using System.Threading.Tasks; // to perform multiple operations
using System.Text;
using System.Linq;
// coupon code problem


class NumberConversion
{
    public static void toBinary()
    {
        string answer;
        string result;

        Console.Write("Input a Number : ");
        answer = Console.ReadLine();

        int num = Convert.ToInt32(answer);
        result = "";
        while (num > 1)
        {
            int remainder = num % 2;
            result = Convert.ToString(remainder) + result;
            num /= 2;
        }
        result = Convert.ToString(num) + result;
        Console.WriteLine("Binary: {0}", result);
        toDecimal(result);
    }

    public static void toDecimal(string result)
    {
        int num2 = int.Parse(result);


        int decVal = 0, baseVal = 1;

        while (num2 > 0)
        {
            //int r = num2%10;
            int rem = num2 % 10;
            decVal = decVal + rem * baseVal;
            num2 = num2 / 10;
            baseVal = baseVal * 2;

        }
        Console.WriteLine("decimal=" + decVal);

    }
}


class Program
{
    static void Main(string[] args)
    {
        NumberConversion.toBinary();
    }
}   
    
