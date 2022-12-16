/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;  значения b1, k1, b2 и k2 задаются пользователем.
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
// Решение с проверками на число и применением методов 
double GetNumber (string message) // Проверка на число
{
    double result;
    while (true)
    {
        System.Console.Write(message);
        if(double.TryParse(Console.ReadLine(), out result))
        break;
        else System.Console.WriteLine("Ввели не число! Повторите ввод!");
    }
    return result;     
}
double [] GetPoint (double b1, double k1, double b2, double k2) // По введенным значениям определяет координаты точки пересечения
{
    double x = Math.Round(((b1 - b2) / (k2 - k1)), 2); // для красоты (округляет до сотых)
    double y = Math.Round((k2 * x + b2), 2); // для красоты (округляет до сотых)
    double [] result = {x, y};  
return (result);
}
Console.Clear();
double b1 = GetNumber("Введите значение b1: ");
double k1 = GetNumber("Введите значение k1: ");
double b2 = GetNumber("Введите значение b2: ");
double k2 = GetNumber("Введите значение k2: ");
double [] result = GetPoint(b1, k1, b2, k2);
System.Console.Write($"Координаты точки пересечения прямых (y = k1 * x + b1) и (y = k2 * x + b2) : ({string.Join(" ; ", result)})"); 

// Вариант решения без проверок и методов
/*Console.Clear();
System.Console.Write("Введите значение b1: ");
string num1 = Console.ReadLine() ?? "";
System.Console.Write("Введите значение k1: ");
string num2 = Console.ReadLine() ?? "";
System.Console.Write("Введите значение b2: ");
string num3 = Console.ReadLine() ?? "";
System.Console.Write("Введите значение k2: ");
string num4 = Console.ReadLine() ?? "";
double b1 = Convert.ToDouble(num1);
double k1 = Convert.ToDouble(num2);
double b2 = Convert.ToDouble(num3);
double k2 = Convert.ToDouble(num4);
double x = (b1 - b2) / (k2 - k1);
double y = k2 * x + b2;
System.Console.WriteLine($"Координаты точки пересечения прямых: ({x},{y})");*/