// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// !!Программа проверяет любую строку на Палиндром!!

Console.WriteLine("Введите на вход любую строку или число:");
string text = Console.ReadLine()!;
int len = text.Length;
if(text.Length % 2 == 0)
{
    string text1 = text.Substring(0, len / 2);
    string text2 =  text.Substring(len / 2, len / 2);
    string text2rev = new string(text2.ToCharArray().Reverse().ToArray());
    if(text1 == text2rev)
    {
        Console.WriteLine($"Строка {text} Является палиндромом");
    }
    else {Console.WriteLine($"Строка {text} Не является палиндромом");}
}
else
{
    string text1 = text.Substring(0, (len - 1) / 2);
    string text2 =  text.Substring((len - 1) / 2 + 1, (len - 1) / 2);
    string text2rev = new string(text2.ToCharArray().Reverse().ToArray());
    if(text1 == text2rev)
    {
        Console.WriteLine($"Строка {text} Является палиндромом");
    }
    else {Console.WriteLine($"Строка {text} Не является палиндромом");}
}

