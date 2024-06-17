// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы. 

void PrintNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
    }
    else
    {
        Console.Write($"{m} ");
        if (m < n)
        {
            PrintNaturalNumbers(m + 1, n);
        }
        else
        {
            PrintNaturalNumbers(m - 1, n);
        }
    }
}

Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");

PrintNaturalNumbers(m, n);
