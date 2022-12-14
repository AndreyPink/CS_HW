using System;
// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 3 числа (после каждого нажмите Enter)");
int max = 0; //обозначаем первоначальное значение максимального элемента
for (int index = 0; index < 3; index ++) //проходим циклом по вводимым числам  
{
    int num = int.Parse(Console.ReadLine()!); //получаем значения
    if(num > max) //сравниваем текущий число с максимальным
    {
        max = num; //обновляем максимальное число
    }
}
Console.WriteLine("Максимальное число = " + max);


// Вариант с сохранением чисел в массив

// Console.WriteLine("Введите 3 числа (после каждого нажмите Enter)");
// int max = 0; //обозначаем первоначальное значение максимального элемента
// int[] nums = new int[3]; //генерим пустой массив из 3-х элементов
// for (int index = 0; index < 3; index ++) //проходим циклом по всем элементам массива c 0-го до 2-го
// {
//     nums[index] = int.Parse(Console.ReadLine()!); //заполняем элементы массива
//     if(nums[index] > max) //сравниваем текущий элемент массива с максимальным
//     {
//         max = nums[index]; //обновляем максимальный элемент
//     }
// }
// Console.WriteLine("Максимальное число = " + max);

