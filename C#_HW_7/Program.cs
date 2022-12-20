Console.WriteLine("Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами. m = 3, n = 4. 0,5 7 -2 -0,2, 1 -3,3 8 -9,9, 8 7,8 -7,1 9.");
int rows = ReadInt("Enter rows number: ");
int columns = ReadInt("Enter columns number: ");
int minVal = -10;
int maxVal = 10;

double[,] numbers = new double[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

void FillMatrixRandomNumbers(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minVal, maxVal);
        }
    }
}


void WriteMatrix(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:F1}", array[i, j]) + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив: 1 4 7 2, 5 9 2 3, 8 4 2 4, 17 -> такого числа в массиве нет.");
int rows2 = ReadInt2("Enter a row index: ");
int colums2 = ReadInt2("Enter a colmn index: ");
int[,] numbers2 = new int[7, 5];
FillArray2D(numbers2);
PrintArray2D(numbers2);

if (rows2 < numbers2.GetLength(0) && colums2 < numbers2.GetLength(1)) Console.WriteLine(numbers2[rows2, colums2]);
else Console.WriteLine($"{rows2}{colums2} -> No number");

void FillArray2D(int[,] array2)
{
    for (int i2 = 0; i2 < array2.GetLength(0); i2++)
    {
        for (int j2 = 0; j2 < array2.GetLength(1); j2++)
        {
            array2[i2, j2] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array2)
{
    for (int i2 = 0; i2 < array2.GetLength(0); i2++)
    {
        for (int j2 = 0; j2 < array2.GetLength(1); j2++)
        {
            Console.Write(array2[i2, j2] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt2(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Например, задан массив: 1 4 7 2, 5 9 2 3, 8 4 2 4, Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");
int rows4 = ReadInt4("Enter rows number: ");
int columns4 = ReadInt4("Enter columns number: ");
int[,] numbers4 = new int[rows4, columns4];
FillMatrixRandomNumbers4(numbers4);
WriteMatrix4(numbers4);

double[] avgNumbers = new double[numbers4.GetLength(1)];
double sum4 = 0;
for (int i4 = 0; i4 < numbers4.GetLength(1); i4++)
{
    for(int j4 = 0; j4 < numbers4.GetLength(0); j4++)
    {
        sum4 += numbers4[j4, i4];
    }
    avgNumbers[i4] = sum4 / numbers4.GetLength(0);
        sum4 = 0;
}
PrintArray(avgNumbers);

void FillMatrixRandomNumbers4(int[,] array4)
{
    for(int i4 = 0; i4 < array4.GetLength(0); i4++)
    {
        for(int j4 = 0; j4 < array4.GetLength(1); j4++)
        {
            array4[i4, j4] = new Random().Next(1, 10);
        }
    }
}



void WriteMatrix4(int[,] array4)
{
    for(int i4 = 0; i4 < array4.GetLength(0); i4++)
    {
        for(int j4 = 0; j4 < array4.GetLength(1); j4++)
        {
            Console.Write(array4[i4, j4] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array4)
{
    for (int i4 = 0; i4 < array4.Length; i4++)
    {
        Console.Write("{0:f2}", array4[i4] + " ");
    }
    Console.WriteLine();
}

int ReadInt4(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");
Console.WriteLine("Thanks for checking! Have a nice day!");
Console.WriteLine(" ");