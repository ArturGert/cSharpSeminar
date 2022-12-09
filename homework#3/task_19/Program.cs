/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом. 14212 -> нет; 12821 -> да; 23432 -> да*/
// Первый вариант решения задачи:
Boolean CheckPalindrom (string number)
{
bool isCorrect = false; 
int num = 0;
while (!isCorrect)
{
System.Console.Write("Введите число: ");
        if(int.TryParse(Console.ReadLine() ?? "", out num) && num > 0)
        {
            string str = Convert.ToString(num); // конвертирует введенное число в строку
            int diff = 0;
            for (int i = 0; i < str.Length/2; i++)
            diff = str[i] - str[str.Length-1-i]; // условие палиндромности: если от первой цифры отнять последнюю и получить "О" и т.д. до середины числа/строки, значит число палиндром
            if (diff==0)
            isCorrect = true; 
            else return false;
        }   
else System.Console.WriteLine("Ввели некорректное число! Повторите ввод!");
}
return true;
}
if(CheckPalindrom("Введите число"))
    System.Console.WriteLine($"Введенное число является палиндромом");
else System.Console.WriteLine($"Введенное число не является палиндромом");

// Второй вариант решения задачи (математический):
/*Console.Clear();
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.Write(message);  
        if(int.TryParse(Console.ReadLine(), out result) && result > 0) // проверка правильности ввода числа
            isCorrect = true;
        else System.Console.WriteLine("Ввели некорректное число! Повторите ввод!");
    }
    return result;
Console.Clear();
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.Write(message);  
        if(int.TryParse(Console.ReadLine(), out result) && result !=0 && result > 0) // проверка правильности ввода числа
            isCorrect = true;
        else System.Console.WriteLine("Ввели некорректное число! Повторите ввод!");
    }
    return result;
}
int n = GetNumber("Введите число: ");
int m = 0;
while (n > 0)
{
   int a = n % 10;
   m = m *=10 + a;
   n = n /=10;
}
if (n==m)
    System.Console.WriteLine($"Введенное число является палиндромом");
else System.Console.WriteLine($"Введенное число не является палиндромом");*/