/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

// Проверка на число
int GetNumber(string message)
{
    int result;
    while (true)
    {
        System.Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else System.Console.WriteLine("Введено недопустимое значение! Повторите ввод!");
    }
    return result;
}
// Функция выдачи значений
string AddNumbers(int n)
{
    if(n == 1)
        return n.ToString();
    return n + ", " + AddNumbers(n-1);
}
Console.Clear();
int n = GetNumber("Введите число N: ");
System.Console.WriteLine(AddNumbers(n));
