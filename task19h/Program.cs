// Задача 19 - HARD необязательная

//Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

static bool IsPalindrome(int number) 
{
    int originalNumber = number;
    int reversedNumber = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit; 
        number /= 10;
    }

    return originalNumber == reversedNumber;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsPalindrome(number) ? "Число является палиндромом" : "Число не является палиндромом");

