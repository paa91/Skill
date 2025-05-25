using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            double vklad = Convert.ToDouble(Console.ReadLine());
            double percent = 0;
            if (vklad < 100)
            {
                percent = 0.05;
            }
            else if (vklad <= 200)
            {
                percent = 0.07;
            }
            else
            {
                percent = 0.1;
            }
            vklad += vklad * percent + 15;

            Console.WriteLine($"Сумму вклада после начисления процентов: {vklad}");

            Console.ReadKey();
        }
    }
}