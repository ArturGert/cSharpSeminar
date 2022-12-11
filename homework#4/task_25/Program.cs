/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
// Проверка корректности ввода чисел
int GetNumber (string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.Write(message);  
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
            isCorrect = true;
        else Console.WriteLine("Введено недопустимое значение");
    }
    return result;
}
// Возводит число в заданную степень
int GetExponentiation (int a, int b)
{
   int exp = 1;
   for (int i = 1; i <= b; i++)
        exp *= a;
    return exp;
}
Console.Clear();
int a = GetNumber("Введите число a: ");
int b = GetNumber("Введите число b: ");
int exp = GetExponentiation(a, b);
System.Console.Write($"Число {a} в степени {b} равно {exp}");