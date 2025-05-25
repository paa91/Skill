using System;

namespace HelloApp 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите сумму вклада для расчета: ");
            double vklad = Convert.ToDouble(Console.ReadLine());

            if (vklad < 100)
            {
                vklad += vklad * 0.05;
            }
            else if (vklad < 200)
            {
                vklad += vklad * 0.07;
            }
            else 
            {
                vklad += vklad * 0.1;
            }
                Console.WriteLine($"Сумма вклада с процентами будет составлять {vklad}");
        }
    }
}
