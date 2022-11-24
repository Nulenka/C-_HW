Console.WriteLine(" ");
Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет, 12821 -> да, 23432 -> да.");

Console.Write("Enter a five-digit number: ");
int FDNumber = Convert.ToInt32(Console.ReadLine());
int firstDigit = ((FDNumber % 100000) - (FDNumber % 10000)) / 10000;
int lastDigit = FDNumber % 10;
int secondDigit = ((FDNumber % 10000) - (FDNumber % 1000)) / 1000;
int fourthDigit = ((FDNumber % 100) - (FDNumber % 10)) / 10;

if (firstDigit == lastDigit && secondDigit == fourthDigit)
{
    Console.WriteLine("Yes, it's the palindrome");
}
else
{
    Console.WriteLine("No, it is not the palindrome");
}

Console.WriteLine(" ");

Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8), B (2,1,-7), -> 15.84; A (7,-5, 0), B (1,-1,9) -> 11.53;");

int aX = ReadInt2("Enter A coordinate X: ");
int aY = ReadInt2("Enter A coordinate Y: ");
int aZ = ReadInt2("Enter A coordinate Z: ");
int bX = ReadInt2("Enter B coordinate X: ");
int bY = ReadInt2("Enter B coordinate Y: ");
int bZ = ReadInt2("Enter B coordinate Z: ");

int sqrSideX = (aX - bX) * (aX - bX);
int sqrSideY = (aY - bY) * (aY - bY);
int sqrSideZ = (aZ - bZ) * (aZ - bZ);
double distance = Math.Sqrt(sqrSideX + sqrSideY + sqrSideZ);
Console.WriteLine(distance);

int ReadInt2(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125.");
int n = ReadInt1("Enter a number: ");
int i = 1;

while(i <= n)
{
    Console.Write(Pow(i++) + " ");
}
int Pow(int n)
{
    return n * n * n;
}

int ReadInt1(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Console.WriteLine("Thanks for checking, have a nice day!");
Console.WriteLine(" ");