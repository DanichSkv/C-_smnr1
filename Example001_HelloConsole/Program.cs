//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int num1, num2;
Console.Write("Привет! Это программа сравнения двух чисел между собой! Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Супер! А теперь введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Итак, если мои расчёты верны, то наибольшее число из этой пары = ");
if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
