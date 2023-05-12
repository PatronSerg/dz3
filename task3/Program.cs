// Задача 3 НЕОБЯЗАТЕЛЬНАЯ. 
// Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) . 
// Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, 
// сами значения предикатов случайные, проверяем это утверждение 100 раз, с помощью модуля time выводим на экран ,
// сколько времени отработала программа. В конце вывести результат проверки истинности этого утверждения.


//Console.WriteLine(!(a && b && c) == !a || !b || !c);
using System.Diagnostics;
DateTime startTime = DateTime.Now;
bool XraZ()
{
    Random lesha = new Random();

    bool[] iarek = new bool[lesha.Next(5, 26)];

    for (int i = 0; i < iarek.Length; i++)
    {
        iarek[i] = Convert.ToBoolean(lesha.Next(0, 2));
    }

    //Console.WriteLine(iarek[0]);

    bool left = iarek[0] && iarek[1];
    bool pravaia = !iarek[0] || !iarek[1];

    for (int i = 2; i < iarek.Length; i++)
    {
        left = left && iarek[i];
        pravaia = pravaia || !iarek[i];
    }
    return !left == pravaia;

}

//Console.WriteLine(XraZ());


System.Diagnostics.Stopwatch sw = new Stopwatch();
sw.Start();
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(XraZ());
}
sw.Stop();
Console.WriteLine((sw.ElapsedMilliseconds / 100.0).ToString());



// Измеряемый код

DateTime endTime = DateTime.Now;
TimeSpan timeElapsed = endTime - startTime;

Console.WriteLine("Время выполнения программы: " + timeElapsed.TotalMilliseconds + " мс");

