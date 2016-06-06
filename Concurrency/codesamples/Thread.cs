using System;
using System.Threading;
using System.Threading.Tasks;

public class Threading
{
    public void dummy(){
        // var t = new Thread(PrintAfter10Seconds);
        // t.Start();
        // t.Join();
        var t = Task.Factory.StartNew(PrintAfter10Seconds);
        Console.WriteLine("Main thread");
        t.Wait();
    }

    public void PrintAfter10Seconds(){
        Thread.Sleep(TimeSpan.FromSeconds(10));
        Console.WriteLine("Hi from thread");
    }

}