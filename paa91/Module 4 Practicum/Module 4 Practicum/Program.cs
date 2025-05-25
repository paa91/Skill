using System;

public class MyClass 
{
    static void Main(string[] args) 
    {
        (string Name, string Surname, string Login, int LoginLength, bool Pet, double Age, string[] favcolor) User;

        for (int k = 0; k < 3; k++)
        {
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.Surname = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у Вас животные? Да или нет?");
            var result = Console.ReadLine();

            if (result == "Да")
                User.Pet = true;
            else
                User.Pet = false;

            Console.WriteLine("Введите возраст");
            User.Age = double.Parse(Console.ReadLine());

            User.favcolor = new string[3];
            Console.WriteLine("Введите 3 любимых цвета");

            for (int i = 0; i < User.favcolor.Length; i++)
                User.favcolor[i] = Console.ReadLine();

        }
    }
}