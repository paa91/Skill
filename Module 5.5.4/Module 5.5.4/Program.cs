using System;

class MainClass
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Напишите что-то");
        //var str = Console.ReadLine();

        //Console.WriteLine("Укажите глубину эха");
        //var deep = int.Parse(Console.ReadLine());

        Factorial(20);

        Console.WriteLine(Factorial(20));   
        Console.ReadKey();
    }

    //static void Echo(string saidworld, int deep)
    //{
    //    var modif = saidworld;

    //    if (modif.Length > 2)
    //    {
    //        modif = modif.Remove(0, 2);
    //    }

    //    Console.BackgroundColor = (ConsoleColor)deep;

    //    Console.WriteLine("..." + modif);

    //    if (deep > 1)
    //    {
    //        Echo(modif, deep - 1);
    //    }
    //}

    static decimal Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}