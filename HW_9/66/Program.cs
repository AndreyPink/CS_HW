// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдет сумму элементов
// в промежутке от M до N. 
// Выполнить с помощью рекурсии.


int SumElem(int m, int n)
{
if(n > m) return n > m ? n + SumElem(m, n - 1) : n;
else return m > n ? m + SumElem(m - 1, n) : m;
}
Console.WriteLine(SumElem(4, 8));