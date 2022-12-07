Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2");
int size7 = ReadInt7("Введите размер массива: ");
int[] numbers7 = new int[size7];
int count7 = 0;

FillArrayRandomNumbers7(numbers7, 100, 999);
WriteArray7(numbers7);

for(int i7 = 0; i7 < numbers7.Length; i7++)
{
    if (numbers7[i7] % 2 != 0)
    continue;
count7++;
}
Console.WriteLine($"Количество четных чисел = {count7}");

void FillArrayRandomNumbers7(int[] array, int min, int max)
{
    for(int i7 = 0; i7 < array.Length; i7++)
    {
        array[i7] = new Random().Next(min, max + 1);
    }
}

void WriteArray7(int[] array)
{
    for(int i7 = 0; i7 < array.Length; i7++)
    {
        Console.Write(array[i7] + " ");
    }
Console.WriteLine();
}

int ReadInt7(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");


Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0");
int size = 4;
int[] numbers = new int[size];
int sumEven = 0;

FillArrayRandomNumbers(numbers, -99, 99);
WriteArray(numbers);

for(int i2 = 0; i2 < numbers.Length; i2++)
{
    if (i2 % 2 != 1)
    continue;
    sumEven += numbers[i2];
}
Console.WriteLine($"Сумма элементов (четные позиции) равна: {sumEven}");

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i2 = 0; i2 < array.Length; i2++)
    {
        array[i2] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for(int i2 = 0; i2 < array.Length; i2++)
    {
        Console.Write(array[i2] + " ");
    }
}
Console.WriteLine(" ");



Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. [3 7 22 2 78] -> 76.");
int size9 = 5;
int[] numbers9 = new int[size9];
FillArrayRandomNumbers9(numbers9);
WriteArray9(numbers9);

int max = numbers9[0];
int min = numbers9[0];

for (int i9 = 0; i9 < numbers9.Length; i9++)
{
    if (numbers9[i9] > max)
    {
        max = numbers9[i9];
    }
    else if (numbers9[i9] < min)
    {
        min = numbers9[i9];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным элементами: {max-min}");

void FillArrayRandomNumbers9(int[] array)
{
    for (int i9 = 0; i9 < array.Length; i9++)
    {
        array[i9] = new Random().Next(1, 100);
    }
}


void WriteArray9(int[] array)
{
    for (int i9 = 0; i9 < array.Length; i9++)
    {
        Console.Write(array[i9] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");

Console.WriteLine("Спасибо за проверку!");
Console.WriteLine(" ");