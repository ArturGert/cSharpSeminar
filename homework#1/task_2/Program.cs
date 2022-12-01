/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Clear();
Console.Write("Введите первое число ");
string first_number = Console.ReadLine() ?? "";
Console.Write("Введите второе число ");
string second_number = Console.ReadLine() ?? "";
int a = Convert.ToInt32(first_number);
int b = Convert.ToInt32(second_number);
if (a > b)
{
   Console.WriteLine($"Большее число: {a} , меньшее число: {b} ");
}else
{
    if (a == b)
        {
       Console.WriteLine($"Введенные числа равны"); 
        } else
        {
        Console.WriteLine($"Большее число: {b}, меньшее число: {a} ");
        }   
}