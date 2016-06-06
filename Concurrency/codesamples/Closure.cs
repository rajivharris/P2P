using System;

public class Closure
{
    public static void Run()
    {
        var inc = GetAFunc();
        Console.WriteLine(inc(5));
        //inc = GetAFunc();
        Console.WriteLine(inc(6));
    }

    public static Func<int, int> GetAFunc()
    {
        var myVar = 1;
        Func<int, int> inc = delegate (int var1)
                                {
                                    //int myvar = 1;
                                    myVar = myVar + 1;
                                    return var1 + myVar;
                                };
        return inc;
    }
}