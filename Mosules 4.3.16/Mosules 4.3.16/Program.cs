using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        var result = 0;

        foreach (var i in arr) 
        {
            if ( i > 0)
                result++;
        }
          
        Console.WriteLine(result);
    }
}