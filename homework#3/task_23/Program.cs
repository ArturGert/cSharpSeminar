
/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.Clear();
System.Console.WriteLine("Введите число ");
string numbers = Console.ReadLine() ?? "";
int n = Convert.ToInt32(numbers);
if (n >= 1)
{
for (int i = 1; i <= n; i++)
    {
        Console.Write($" {Math.Pow(i,3)} ");
    }
}
else System.Console.WriteLine("Ввели некорректное число! Повторите ввод!"); 
// Math.Pow(i,3);