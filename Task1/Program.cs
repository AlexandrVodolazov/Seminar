﻿// Напишите программу , которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да
// a = 2; b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3; b = 9 -> да

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.Write("Введите второе число: ");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a * a == b)
{
    Console.WriteLine("Второе число является квадратом первого числа");
}

else 
{
    Console.WriteLine("Второе число не является квадратом первого числа");
}


