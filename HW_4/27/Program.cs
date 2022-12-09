// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CountNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int x =num%10;
        num /= 10;
        sum += x;
    }
    return sum;
}
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр в числе {n} = {CountNum(n)}");
