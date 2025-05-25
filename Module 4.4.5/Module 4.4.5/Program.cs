using System;

class MainClass
{
    
    public static void Main(string[] args)
    {
        (string name, string type, double age, int namecount) pet;

        Console.WriteLine("Введите имя питомца: ");
        pet.name = Console.ReadLine();
        pet.namecount = pet.name.Length;

        Console.WriteLine("Введите тип питомца (кошка, собака, бабака): ");
        pet.type = Console.ReadLine();

        Console.WriteLine("Введите возраст питомца: ");
        pet.age = double.Parse(Console.ReadLine());



        Console.WriteLine("Имя питомца {0}", pet.name);
        Console.WriteLine("Возраст питомца {0}", pet.age);
        Console.WriteLine("Тип вашего питомца {0}", pet.type);
        Console.WriteLine("Длина имени питомца {0}", pet.namecount);

        Console.ReadKey();
    }
}