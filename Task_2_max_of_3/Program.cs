//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int num1, num2, num3;
Console.Write("Привет! Это программа сравнения трех чисел между собой! Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Супер! А теперь введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Супер! А теперь введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Итак, если мои расчёты верны, то наибольшее число из этих трёх = ");
if (num1>num2)
{
    if (num1>num3)
    {
        Console.WriteLine(num1);
    }
    else
    {
        Console.WriteLine(num3);
    }
}
else
{
    if (num2>num3)
    {
        Console.WriteLine(num2);
    }
    else
    {
        Console.WriteLine(num3);
    }
}