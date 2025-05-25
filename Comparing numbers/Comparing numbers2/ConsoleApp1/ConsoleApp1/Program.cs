using System;
using System.ComponentModel.Design;

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 5 && num1 < 10)
{
    Console.WriteLine("Число больше 5 и меньше 10");
}
else
{
    Console.WriteLine("Неизвестное число");
}
