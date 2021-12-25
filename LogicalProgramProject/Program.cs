using System;
using System.Collections.Generic;
using System.Threading.Tasks; // to perform multiple operations
using System.Text;
using System.Linq;
// coupon code problem


class VendingMachine
{
    // function to count and
    // print currency notes
    public static void countCurrency(int amount)
    {
        int[] notes = new int[]{ 2000, 500, 200, 100,
                     50, 20, 10, 5, 1 };
        int[] noteCounter = new int[9];

        // count notes using Greedy approach
        for (int i = 0; i < 9; i++)
        {
            if (amount >= notes[i])
            {
                noteCounter[i] = amount / notes[i];
                amount = amount - noteCounter[i] * notes[i];
                Console.WriteLine(amount);
            }
        }

        // Print notes
        Console.WriteLine("currency count ->");
        int[] notes1 = new int[]{ 2000, 500, 200, 100,
                     50, 20, 10, 5, 1 };
        int largestnote;
        for (int i = 0; i < 9; i++)
        {
            if (noteCounter[i] != 0)
            {
                Console.WriteLine(notes[i] + " : " + noteCounter[i]);

            }

        }


    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an Amount: ");
        int num = Convert.ToInt32(Console.ReadLine());
        VendingMachine.countCurrency(num);
        
    }
}   
    
