Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. N = 5 -> 5, 4, 3, 2, 1, N = 8 -> 8, 7, 6, 5, 4, 3, 2, 1");

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = 1;
NatToLow(number, temp);


void NatToLow(int n, int temp)
{
    if (temp > n)
    {
        return;
    }
    else
    {
        NatToLow(n, temp + 1);
        Console.Write(temp + ", ");
    }
}
Console.WriteLine();

Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. M = 1; N = 15 -> 120, M = 4; N = 8. -> 30");

Console.Write("Enter M: ");
int m3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N, should be > M: ");
int n3 = Convert.ToInt32(Console.ReadLine());

WriteMToN(m3, n3);

void WriteMToN(int m3, int n3)
{
    Console.WriteLine(SumMN3(m3 - 1, n3));
}

int SumMN3(int m3, int n3)
{
    if (n3 > m3)
    {
        int result = m3;
        if (m3 == n3)
            return 0;
        else
        {
            m3++;
            result = m3 + SumMN3(m3, n3);
            return result;
        }
    }
    else return 0;
}
Console.WriteLine();

Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 9, m = 3, n = 2 -> A(m,n) = 29");

Console.Write("Enter M > 0: ");
int m4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N > 0: ");
int n4 = Convert.ToInt32(Console.ReadLine());

WriteAkkerman(m4,n4);

void WriteAkkerman(int m4, int n4)
{
    Console.Write(Akkerman(m4, n4)); 
}

int Akkerman(int m4, int n4)
{
    if (m4 == 0)
    {
        return n4 + 1;
    }
    else if (n4 == 0 && m4 > 0)
    {
        return Akkerman(m4 - 1, 1);
    }
    else
    {
        return (Akkerman(m4 - 1, Akkerman(m4, n4 - 1)));
    }
}