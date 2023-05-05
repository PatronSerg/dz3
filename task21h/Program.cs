// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.


Console.WriteLine("Задайте N-мерность пространства:");
int N = Convert.ToInt32(Console.ReadLine());


int[] Jopa = new int[N];
int[] Pezda = new int[N];


for (int i = 0; i < Jopa.Length; i++)
{
    Console.WriteLine($"Задайте {i+1} координату первой точки пространства:");
    Jopa[i]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Задайте {i+1} координату второй точки пространства:");
    Pezda[i]=Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(Jopa[i]);
}





// for(int i=0;i<N;i++);
// {

//     int x1 = Convert.ToInt32(Console.ReadLine());
// }