using System;
using System.Threading;
using System.Threading.Tasks;

public class AsyncPrograms
{
    public async Task Run(){

var t = 1;

        System.Console.WriteLine("Req received");

       var t1 = new Task(webservicecall);
       var t2 = new Task(webservicecall);
       var t3 = new Task(webservicecall);
       var t4 = new Task(webservicecall);

       await Task.WhenAll(t1,t2,t3,t4);
       

        System.Console.WriteLine("Some more process");

        //make db call - 5 mins
        await dbcall();

        Console.WriteLine("Done");
    }

    void webservicecall(){
        //Thread.Sleep(TimeSpan.FromSeconds(2));
         Task.Delay(TimeSpan.FromSeconds(2));
    }

    Task dbcall(){
         return Task.Delay(TimeSpan.FromSeconds(2));
    }
}