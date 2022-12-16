/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Clear();
Console.Write("Ввидите число: ");
int number1 = int.Parse(Console.ReadLine()!);

if (number1 % 2 == 0)
{
    Console.Write($"Число {number1} четное.");
}
else 
{
    Console.Write($"Число {number1} нечетное.");
}