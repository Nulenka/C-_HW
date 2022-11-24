Console.WriteLine(" ");
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5, 782 -> 8, 918 -> 1.");

Console.Write("Enter a three-digit number: ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());

if(ThreeDigitNumber > 99 && ThreeDigitNumber < 1000)
{
    int SecondDigit = ((ThreeDigitNumber % 100) - (ThreeDigitNumber % 10)) / 10;
    Console.WriteLine(SecondDigit);
}
else
{
    Console.WriteLine("Wrong number entered");
}
Console.WriteLine(" ");
//teacher's way:
//enter a number;
//Console.WriteLine(number/100%10);


Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или cообщает, что третьей цифры нет. 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6.");

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int searchDigit = 3;
int count = 0;
int temp = number;

if(number > 99)
{
        while(temp > 0)
    {
        temp /= 10;  // temp = temp / 10
        count++;
    }

    while(count > searchDigit)
    {
        number /= 10;
        count--;
    }

    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("No third digit fount");
}


// my variation

Console.Write("Enter a number: ");
int SomeNumber = Convert.ToInt32(Console.ReadLine());

if(SomeNumber > 99 && SomeNumber < 1000)
{
    int ThirdDigit = SomeNumber % 10;
    Console.WriteLine(ThirdDigit);
}

else if(SomeNumber > 999 && SomeNumber < 10000)
{
    int ThirdDigitA = ((SomeNumber % 100) - (SomeNumber % 10)) / 10;
    Console.WriteLine(ThirdDigitA);
}

else if(SomeNumber > 9999 && SomeNumber < 100000)
{
    int ThirdDigitB = ((SomeNumber % 1000) - (SomeNumber % 100)) / 100;
    Console.WriteLine(ThirdDigitB);
}

else if(SomeNumber > 99999 && SomeNumber < 1000000)
{
    int ThirdDigitC = ((SomeNumber % 10000) - (SomeNumber % 1000)) / 1000;
    Console.WriteLine(ThirdDigitC);
}

else if(SomeNumber > 999999 && SomeNumber < 10000000)
{
    int ThirdDigitD = ((SomeNumber % 100000) - (SomeNumber % 10000)) / 10000;
    Console.WriteLine(ThirdDigitD);
}

else if(SomeNumber > 9999999)
{
    Console.WriteLine("You do want too much from me, I just study...");
}

else
{
    Console.WriteLine("The third number does not exist");
}

Console.WriteLine(" ");

Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да, 7 -> да, 1 -> нет.");

Console.Write("Enter a number of the day of the week: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if(DayNumber >= 1 && DayNumber <= 5)
{
    Console.WriteLine("No, weekdays");
}

else if(DayNumber >= 6 && DayNumber <= 7)
{
    Console.WriteLine("Yes, have a nice weekend!");
}

else
{
    Console.WriteLine("Wrong number entered");
}
Console.WriteLine(" ");

Console.WriteLine("Thanks for checking, have a nice day!");

Console.WriteLine(" ");