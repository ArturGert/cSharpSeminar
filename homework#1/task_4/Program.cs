/*Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();
Console.Write("Введите первое число ");
string first_number = Console.ReadLine() ?? "";
Console.Write("Введите второе число ");
string second_number = Console.ReadLine() ?? "";
Console.Write("Введите третье число ");
string third_number = Console.ReadLine() ?? "";

int a = Convert.ToInt32(first_number);
int b = Convert.ToInt32(second_number);
int c = Convert.ToInt32(third_number);
int max_number = a;
if (a > b)
{
    max_number = a;
}
else if (b > c)
{
    max_number = b; 
}
else max_number = c;  
Console.WriteLine($"Максимальное число: {max_number}");
