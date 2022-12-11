/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11; 82 -> 10; 9012 -> 12*/
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
            System.Console.Write(message);
            if(int.TryParse(Console.ReadLine(), out result) && result > 0)
            isCorrect = true; 
            else System.Console.WriteLine("Введено недопустимое значение! Повторите ввод!");
    }
    return result;
}
int GetSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int m = n %10;
        n /= 10;
        sum += m;
    }
    return sum;
}
Console.Clear();
int n = GetNumber("Введите число: ");
int sum = GetSum(n);
System.Console.Write($"Сумма цифр цисла {n} составляет: {sum}");