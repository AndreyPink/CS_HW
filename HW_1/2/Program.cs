// // Задача 2: Напишите программу,
//  которая на вход принимает два числа 
//  и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 2 числа (после каждого нажмите Enter)");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
if (number1 > number2)
{
    Console.WriteLine("Наибольшее число - " + number1 + ",наименьшее число - " + number2);
}
else
{
    Console.WriteLine("Наибольшее число - " + number2 + ",наименьшее число - " + number1);
}
