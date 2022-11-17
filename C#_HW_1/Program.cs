Console.WriteLine(" ");
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7; a = 2 b = 10 -> max = 10; a = -9 b = -3 -> max = -3");

Console.Write("Enter a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if(a > max) max = a;
if(b > max) max = b;

int min = b;
if(a < min) min = a;
if(b < min) min = b;

Console.Write("max ->  ");
Console.Write(max + "  ");

Console.Write("min ->  ");
Console.WriteLine(min);
Console.WriteLine(" ");


Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 2, 3, 7 -> 7; 44 5 78 -> 78; 22 3 9 -> 22");
Console.Write("Enter the first number: ");
int C = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int D = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int E = Convert.ToInt32(Console.ReadLine());

int maximum = C;
if(C > maximum) maximum = C;
if(D > maximum) maximum = D;
if(E > maximum) maximum = E;

Console.Write("max ->  ");
Console.WriteLine(maximum);
Console.WriteLine(" ");


Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 4 -> да; -3 -> нет; 7 -> нет");
Console.Write("Enter a number: ");
int F = Convert.ToInt32(Console.ReadLine());

if((F % 2) == 0)
{
    Console.WriteLine("Yes, it's an even number");
    Console.WriteLine(" ");
}
else
{
        Console.WriteLine("No, it's not an even number");
        Console.WriteLine(" ");
}


Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4; 8 -> 2, 4, 6, 8.");
Console.Write("Enter a number: ");
int J = Convert.ToInt32(Console.ReadLine());

int i = 2;
while(i <= J)
{
    Console.Write(i + " ");
    i += 2;
}

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Thanks for checking! Have a nice day!");
Console.WriteLine(" ");