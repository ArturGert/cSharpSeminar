/* Задача 6: Напишите программу, которая на вход принимает 
число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Clear();
Console.Write("Введите число ");
string number = Console.ReadLine() ?? "";
int N = Convert.ToInt32(number);
if (N % 2 == 0)
{
   Console.WriteLine("Число является четным");
}