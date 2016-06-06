using System;
using System.Threading;
public class BasicWaitHandle
{
  static EventWaitHandle _waitHandle = new AutoResetEvent (false);
 
  public static void Run()
  {
    var t1 = new Thread (Waiter);
    var t2 = new Thread(setHandler);
    t1.Start();
    t2.Start();
    Console.WriteLine("Done");
    
    t2.Join();
  t1.Join();
  }
 
  static void Waiter()
  {
    Console.WriteLine ("Waiting...");
    _waitHandle.WaitOne();                // Wait for notification
    Console.WriteLine ("Notified");
  }

  static void setHandler(){
    Console.WriteLine("setHandler");
    Thread.Sleep (3000);                  // Pause for a second...
    //Console.ReadLine();
    _waitHandle.Set();                    // Wake up the Waiter.

  }


}