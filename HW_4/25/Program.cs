// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumPow(int A, int B)
{
     
    int pow = (int)Math.Pow(A, B);
    return pow;
}
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);
Console.Write($"A в степени В = {NumPow(a, b)}");
