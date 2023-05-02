// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Rast(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2)));
}


Console.WriteLine("Введите Координату x1 для точки А");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату y1 для точки А");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату z1 для точки А");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату x2 для точки B");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату y2 для точки B");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату z2 для точки B");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между двяму точками равно: {Math.Round(Rast(x1, y1, z1, x2, y2, z2), 3)}");