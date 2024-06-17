// Задача №2. Напишите программу для вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа n и m. 

// Функция Аккермана 

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
    else
    {
        // Этот случай никогда не достигнет ввода натуральных чисел m и n
        throw new ArgumentException("m и n должны быть неотрицательными.");
    }
}

// Ввод значений m и n
Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Вызов функции Аккермана и вывод результата
int result = AckermanFunction(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");