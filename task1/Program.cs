﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"Max = {numberA}");
}
else if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine($"Max = {numberB}");
} 
else if (numberC > numberA && numberC > numberB)
{
    Console.WriteLine($"Max number is: {numberC}");
}

