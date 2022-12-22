using System;
// Задача 60: Заполните спирально массив 4 на 4.

// !!РАЗОБРАТЬСЯ КАК РАБОТАЕТ ЭТОТ МЕТОД!!
// int[,] Spiral(int n)
// {
//     int[,] result = new int[n, n];

//     int pos = 1;
//     int count = n;
//     int value = -n;
//     int sum = -1;

//     do
//     {
//         value = -1 * value / n;
//         for (int i = 0; i < count; i++)
//         {
//             sum += value;
//             result[sum / n, sum % n] = pos++;
//         }
//         value *= n;
//         count--;
//         for (int i = 0; i < count; i++)
//         {
//             sum += value;
//             result[sum / n, sum % n] = pos++;
//         }
//     } while (count > 0);

//     return result;
// }



void PrintArray(int[,] matrix)
{
    Console.WriteLine("Заполненный массив\n");
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]}\t");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine();
}

// PrintArray(Spiral(4));

int[,] Spiral(int n)
{

    int[,] array = new int[n, n];
    int rows = 0;
    int columns = 0;
    int elem = 1;
    while (n != 0)
    {
        int count = 1;
        while (n > count)
        {
            array[rows, columns++] = elem++;
            count++;
        } 
        for (count = 0; count < n - 1; count++) 
        array[rows++, columns] = elem++;

        for (count = 0; count < n - 1; count++) 
        array[rows, columns--] = elem++;

        for (count = 0; count < n - 1; count++) 
        array[rows--, columns] = elem++;

        rows++;
        columns++;
        if (n < 2) n = 0;
        else n -= 2;
    }
    Console.WriteLine();
    return array;
}

PrintArray(Spiral(4));