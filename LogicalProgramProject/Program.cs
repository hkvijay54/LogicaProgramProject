using System;
using System.Collections.Generic;
using System.Threading.Tasks; // to perform multiple operations
using System.Text;
using System.Linq;
// coupon code problem

class Program
{
    static void Main(string[] args)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var stringChar = new char[6];
        var random=new Random();

        Console.WriteLine("How many tickets to generate?");
        int number = Convert.ToInt32(Console.ReadLine());

        while(number > 0)
        {
            for(int i = 0; i < stringChar.Length; i++)
            {
                stringChar[i]= chars[random.Next(chars.Length)];
            }

            var finalString=new String(stringChar);
            Console.WriteLine(finalString);

            number--;
        }
    }
}   
    
