﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
вторую цифру этого числа: 456 -> 5; 782 -> 8; 918 -> 1*/

Console.Clear();
Console.WriteLine("Введите трёхзначное число ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(-N);
if ((N>=100) && (N<=999))
{
   Console.WriteLine((N/10) % 10); 
}
else Console.Write("ERROR! Введено недопустимое значение!!!");
