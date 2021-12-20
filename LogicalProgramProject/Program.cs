using System;
using System.Diagnostics; // to use Stopwatch feature
using System.Threading; // to perform multiple operations

// Write a Stopwatch Program for measuring the time that elapses between
//the start and end clicks

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopw = new Stopwatch();
        Console.WriteLine("Press any key to start");
        Console.ReadLine();
        Console.WriteLine("StopWatch started");
        stopw.Start();
        Console.WriteLine("Press Any key to stop when you want");
        Console.ReadLine();
        stopw.Stop();
        Console.WriteLine("Stopped Stopwatch: Time elapsed: {0} ", stopw.Elapsed);
    }
}   
    
