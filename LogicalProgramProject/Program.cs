using System;
using System.Collections.Generic;
using System.Threading.Tasks; // to perform multiple operations
using System.Text;
using System.Linq;
// coupon code problem


class NumberConversion
{
    public static  int swapNibble(int x)
    {
        return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
    }
}


class Program
{
    static void Main(string[] args)
    {
        int bin = Convert.ToInt32(LogicalProgramProject.Binary.toBinary());
        Console.WriteLine(bin);
        int r = NumberConversion.swapNibble(bin);
        Console.WriteLine(r);
    }
}   
    
