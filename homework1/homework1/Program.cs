using System;

class Program
{
    // Метод проверки корректного ввода числа (возвращает int > 0)
    static int ReadInt(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number > 0)
                return number;
            else
                Console.WriteLine("Ошибка: введите целое число больше 0.");
        }
    }

    // Метод для ввода кличек питомцев
    static string[] GetPetNames(int count)
    {
        string[] petNames = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите кличку питомца #{i + 1}: ");
            petNames[i] = Console.ReadLine();
        }
        return petNames;
    }

    // Метод для ввода любимых цветов
    static string[] GetFavoriteColors(int count)
    {
        string[] colors = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите любимый цвет #{i + 1}: ");
            colors[i] = Console.ReadLine();
        }
        return colors;
    }

    // Метод для ввода данных пользователя
    static (string name, string surname, int age, bool hasPets, string[] petNames, string[] favColors) InputUserData()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine();

        int age = ReadInt("Введите возраст: ");

        Console.Write("Есть ли у вас питомцы? (да/нет): ");
        bool hasPets = Console.ReadLine().Trim().ToLower() == "да";

        string[] petNames = Array.Empty<string>();
        if (hasPets)
        {
            int petCount = ReadInt("Сколько у вас питомцев: ");
            petNames = GetPetNames(petCount);
        }

        int colorCount = ReadInt("Сколько у вас любимых цветов: ");
        string[] favColors = GetFavoriteColors(colorCount);

        return (name, surname, age, hasPets, petNames, favColors);
    }

    // Метод для вывода данных о пользователе
    static void ShowUserData((string name, string surname, int age, bool hasPets, string[] petNames, string[] favColors) user)
    {
        Console.WriteLine("\n--- Данные о пользователе ---");
        Console.WriteLine($"Имя: {user.name}");
        Console.WriteLine($"Фамилия: {user.surname}");
        Console.WriteLine($"Возраст: {user.age}");
        Console.WriteLine($"Наличие питомцев: {(user.hasPets ? "Да" : "Нет")}");

        if (user.hasPets)
        {
            Console.WriteLine("Клички питомцев:");
            foreach (var pet in user.petNames)
                Console.WriteLine($"- {pet}");
        }

        Console.WriteLine("Любимые цвета:");
        foreach (var color in user.favColors)
            Console.WriteLine($"- {color}");
    }

    // Точка входа
    static void Main(string[] args)
    {
        var user = InputUserData();
        ShowUserData(user);
    }
}

