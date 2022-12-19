// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void CreateArray(int a, int b)
{
double[,] matrix = new double[a, b];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        matrix[rows, columns] = Math.Round(new Random().NextDouble()*10, 1);
        Console.Write($"{matrix[rows, columns]}  ");
    }
    Console.WriteLine("");
}
}
Console.WriteLine("Введите размер массива M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер массива N: ");
int n = int.Parse(Console.ReadLine()!);
CreateArray(m,n);
Console.WriteLine("");


