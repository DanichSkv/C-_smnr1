﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

using System.Net.Security;

int num1;
Console.Write("Привет, эта программа проверяет четность числа! Введите чило: ");
num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число нечётное!");
}