/*Задача 21. Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.Clear();
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else System.Console.WriteLine("Введено некорректное значение! Повторите ввод!");
    }
    return result;
}

int n = GetNumber("Введите координаты первой точки ");