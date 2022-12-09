/*Задача 21. Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.Clear();
System.Console.Write("Введите координату xA: ");
string x1 = Console.ReadLine() ?? "";
System.Console.Write("Введите координату yA: ");
string y1 = Console.ReadLine() ?? "";
System.Console.Write("Введите координату zA: ");
string z1 = Console.ReadLine() ?? "";
int xA = Convert.ToInt32(x1);
int yA = Convert.ToInt32(y1);
int zA = Convert.ToInt32(z1);
System.Console.Write("Введите координату xB: ");
string x2 = Console.ReadLine() ?? "";
System.Console.Write("Введите координату yB: ");
string y2 = Console.ReadLine() ?? "";
System.Console.Write("Введите координату zB: ");
string z2 = Console.ReadLine() ?? "";
int xB = Convert.ToInt32(x2);
int yB = Convert.ToInt32(y2);
int zB = Convert.ToInt32(z2);
// Метод определения расстояния
double FoundDistance (int xA, int yA, int zA, int xB, int yB, int zB)
{
    int[] num1 = {xA, yA, zA};
    int[] num2 = {xB, yB, zB};
    double distance = 0;
    double result = 0;
    for (int i = 0; i < 3; i++)
    {
        result = (result + (Math.Pow((num2[i]-num1[i]), 2))); 
        distance = Math.Sqrt(result);
    }
return distance;
}
double ab = FoundDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точкой A ({xA}, {yA}, {zA}) и точкой B ({xB}, {yB}, {zB}) составляет {ab}");