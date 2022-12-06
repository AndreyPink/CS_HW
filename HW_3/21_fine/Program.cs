// Задача 21
// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] dots = new int[6];
string[] names = { "X1", "Y1", "Z1", "X2", "Y2", "Z2" };
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Введите координату {names[i]}");
    dots[i] = int.Parse(Console.ReadLine()!);
}
double d = Math.Round(Math.Sqrt(Math.Pow(dots[3] - dots[0], 2) + Math.Pow(dots[4] - dots[1], 2) + Math.Pow(dots[5] - dots[2], 2)), 2);
Console.WriteLine($"расстояние между точками равно {d}");
