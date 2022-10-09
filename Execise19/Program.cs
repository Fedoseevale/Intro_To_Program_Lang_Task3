// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());

void Number (int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if (num > 99999 || num < 10000 || num == 0) Console.WriteLine ("Введённое число не является пятизначным");
    else if (num1 == num5 && num2 == num4) Console.WriteLine ("Введённое число является полиндромом");
    else Console.WriteLine ("Введённое число не является полиндромом");
}

Number(number);