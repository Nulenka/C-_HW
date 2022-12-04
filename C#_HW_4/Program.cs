Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без использования функции Math.Pow. 3, 5 -> 243 (3⁵), 2, 4 -> 16");
Console.Write("Enter a number: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a natural number: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
int t = Number1;

for (int c = 1; c < Number2; c++)
{
    Number1 *= t;
}
Console.WriteLine(Number1);
Console.WriteLine(" ");


Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11, 82 -> 10, 9012 -> 12.");
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = ((number % 100000) - (number % 10000)) / 10000;
int secondDigit = ((number % 10000) - (number % 1000)) / 1000;
int firdDigit = ((number % 1000) - (number % 100)) / 100;
int fouthdDigit = ((number % 100) - (number % 10)) / 10;
int lastDigit = number % 10;
int sum = 0;

sum = firstDigit + secondDigit + firdDigit + fouthdDigit + lastDigit;
Console.WriteLine(sum);
Console.WriteLine(" ");


Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом. 5 -> [1, 2, 5, 7, 19], 3 -> [6, 1, 33]");
int numberG = ReadInt("Enter a number: ");
int[] numbers = new int[numberG];

for (int e = 0; e < numbers.Length; e++)
{
    numbers[e] = new Random().Next(0, 92);
    Console.Write(numbers[e] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");
Console.WriteLine("Thanks for checking!");