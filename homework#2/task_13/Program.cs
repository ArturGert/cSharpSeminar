/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int ThreeDigitNumber = 0; 
int ThirdDigit = 0;
if (N>=100)
{
    while (N>=1000) 
    ThreeDigitNumber = (N /= 10);
    ThirdDigit = (ThreeDigitNumber %10);
    Console.Write($"Третья цифра заданного числа: {ThirdDigit}"); 
}
else Console.Write("В данном числе 3-я цифра отсутствует");