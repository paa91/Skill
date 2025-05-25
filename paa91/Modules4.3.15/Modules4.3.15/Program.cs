using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 1, -6, 5, 3, -1, 0, -7 };
        int result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0) 
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}