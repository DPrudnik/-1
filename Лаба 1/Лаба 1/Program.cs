using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool allUnique = AreAllElementsUnique(numbers);

        if (allUnique)
        {
            Console.WriteLine("Всі елементи у списку є унікальними.");
        }
        else
        {
            Console.WriteLine("У списку є неунікальні елементи.");
        }
    }

    static bool AreAllElementsUnique(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] == list[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}