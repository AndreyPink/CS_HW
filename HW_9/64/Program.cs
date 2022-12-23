// Задача 64: Задайте значение N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void NaturalNumbers(int n)
{
    Console.Write($"{n} ");
    if(n > 1) NaturalNumbers(n - 1);
}
NaturalNumbers(5);

