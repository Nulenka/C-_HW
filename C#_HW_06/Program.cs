Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 4");

Console.Write("Введите элементы через пробел без запятых: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int minSegment = 0;
int count7 = 0;

for(int i7 = 0; i7 < arr.Length; i7++)
{
    if (arr[i7] < minSegment)
    continue;
count7++;
}
Console.WriteLine(count7);
Console.WriteLine(" ");


Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5. -0,5)"); 
int b1 = ReadInt2("Enter b1: ");
int k1 = ReadInt2("Enter k1: ");
int b2 = ReadInt2("Enter b2: ");
int k2 = ReadInt2("Enter k2: ");

int x = (b2 - b1) / (k1 - k2);
int y = ((k1 * x) + b1);
Console.WriteLine("The point: x = " + x + "; y = " + y);

int ReadInt2(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Thanks for cheking! Have a nice day!");