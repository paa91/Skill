using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = { 5, 2, 9, 1, 7 };

        SortArray(originalArray, out int[] asc, out int[] desc);

        Console.WriteLine("Ascending: " + string.Join(", ", asc));
        Console.WriteLine("Descending: " + string.Join(", ", desc));
    }
    //static int[] GetArrayFromConsole(int num = 5)
    //{
    //    var result = new int[num];

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }

    //    return result;
    //}

    // Метод сортировки с двумя выходными параметрами
    static void SortArray(int[] result, out int[] sortedAsc, out int[] sortedDesc)
    {
        sortedAsc = SortArrayAsc(result);
        sortedDesc = SortArrayDesc(result);
    }

    //Метод сортировки по возрастанию 
    static int[] SortArrayAsc(int[] result)
    {
        int temp;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        return result;
    }

    //Метод сортировки по убыванию
    static int[] SortArrayDesc(int[] result)
    {
        int temp;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] < result[j])
                {
                    temp = result[j];
                    result[j] = result[i];
                    result[i] = temp;
                }
            }
        }

        return result;
    }

    //static void ShowArray(int[] array, bool IsSort = false)
    //{
    //    var temp = array;
    //    if (IsSort)
    //    {
    //        temp = SortArray(array);
    //    }

    //    foreach (var item in temp)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}
}