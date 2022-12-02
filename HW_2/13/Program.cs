// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите скольки-хочешь-значное число");
int num = int.Parse(Console.ReadLine()!);
int numTemp = num;
int count = 0;

while (Math.Abs(numTemp) > 0)   //код позволяет проверять отрицательные числа
{
  numTemp /= 10;
  count++; 
}

if (count - 3 >= 0)
{
    var rank = Math.Pow(10, count - 3);
    var num3 = Math.Truncate(num / rank % 10);
    Console.WriteLine($"Третья цифра числа {num} = {Math.Abs(num3)}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
