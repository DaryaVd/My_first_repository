// Задача №3. Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы. 

// Создание произвольного массива

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }


}
// Cоздание рекурсивной функции для вывода массива в обратном порядке
void PrintReverseArray(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    PrintReverseArray(array, index - 1);
}

int[] arr = CreateArrayRndInt(10, 1, 100);

Console.WriteLine("Первоначальный массив:");

PrintArray(arr);

Console.WriteLine();

Console.WriteLine("Развернутый массив:");

PrintReverseArray(arr, arr.Length - 1);



