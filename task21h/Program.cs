// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.



Console.WriteLine("Задайте N-мерность пространства:");
int N = Convert.ToInt32(Console.ReadLine());


double[] Jopa = new double[N];
double[] Pezda = new double[N];


for (int i = 0; i < Jopa.Length; i++)
{
    Console.WriteLine($"Задайте {i + 1} координату первой точки пространства:");
    Jopa[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Задайте {i + 1} координату второй точки пространства:");
    Pezda[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Расстояние между двяму точками равно: {Math.Round(Rast(Jopa , Pezda), 3)}");



double Rast(double[] Shlepa, double[] Clepa)
{
    double huesha = 0;

    for (int i = 0; i < Clepa.Length; i++)
    {
    huesha = huesha + Math.Pow(Clepa[i] - Shlepa[i], 2);
    }
    return Math.Sqrt(huesha);
    
    //return Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2)));
}








// for(int i=0;i<N;i++);
// {

//     int x1 = Convert.ToInt32(Console.ReadLine());
// }