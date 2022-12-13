// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    int[] array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("\n");
    return array;
}

void Count(int[] myArray)
{
    int sum = 0;
    foreach (int elem in myArray)
    {
        if (elem % 2 == 0) sum++;
    }
    Console.WriteLine($"Кол-во четных чисел {sum}");
}
Count(CreateArray());
