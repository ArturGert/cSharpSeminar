﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
 сообщает, что третьей цифры нет. (645 -> 5, 78 -> третьей цифры нет, 32679 -> 6*/

Console.Clear();
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 100)
{
    while (N >= 1000)
        //Переводим введенное число в трехзначное
        N = (N /= 10);
        // Определяем третью цифру (остаток от деления на 10)
        int FindDigit = (N % 10);
    Console.Write($"Третья цифра заданного числа: {FindDigit}");
}
else Console.Write("В данном числе 3-я цифра отсутствует");