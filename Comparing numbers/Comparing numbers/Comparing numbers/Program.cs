﻿using System;
using System.ComponentModel.Design;

namespace HelloApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите первое число: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите второе число: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			if (num1 > num2)
			{
				Console.WriteLine("Первое число больше второго");
			}
			else if (num1 < num2)
			{
				Console.WriteLine("Второе число больше первого");
			}
			else
			{
				Console.WriteLine("Числа равны");
			}
		}
	}
}