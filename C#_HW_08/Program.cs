Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. Например, задан массив: 1 4 7 2, 5 9 2 3, 8 4 2 4. В итоге получается вот такой массив: 7 4 2 1, 9 5 3 2, 8 4 4 2");

int rows3 = ReadInt3("Enter rows number: ");
int columns3 = ReadInt3("Enter columns number: ");
int[,] table = new int[rows3, columns3];
FillMatrixRandomNumbers3(table);
WriteMatrix3(table);
SortToLower(table);
Console.WriteLine();
WriteMatrix3(table);

void FillMatrixRandomNumbers3(int[,] array3)
{
    for(int i3 = 0; i3 < array3.GetLength(0); i3++)
    {
        for(int j3 = 0; j3 < array3.GetLength(1); j3++)
        {
            array3[i3, j3] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void WriteMatrix3(int[,] array3)
{
    for(int i3 = 0; i3 < array3.GetLength(0); i3++)
    {
        for(int j3 = 0; j3 < array3.GetLength(1); j3++)
        {
            Console.Write(array3[i3, j3] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt3(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Например, задан массив: 1 4 7 2, 5 9 2 3, 8 4 2 4, 5 2 6 7. Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.");

int rows4 = ReadInt4("Enter rows number: ");
int columns4 = ReadInt4("Enter columns number: ");
int[,] numbers4 = new int[rows4, columns4];

FillMatrixRandomNumbers4(numbers4);
WriteMatrix4(numbers4);
Console.WriteLine();
RowWithMinSum4(numbers4);

void RowWithMinSum4(int[,] array4)
{
    int minRow4 = 0;
    int minSumRow4 = 0;
    int sumRow4 = 0;
    for (int i4 = 0; i4 < numbers4.GetLength(1); i4++)
    {
        minRow4 += numbers4[0, i4];
    }
    for (int i4 = 0; i4 < numbers4.GetLength(0); i4++)
    {
        for (int j4 = 0; j4 < numbers4.GetLength(1); j4++) sumRow4 += numbers4[i4, j4];
        if (sumRow4 < minRow4)
        {
            minRow4 = sumRow4;
            minSumRow4 = i4;
        }
        sumRow4 = 0;
    }
    Console.WriteLine($"{minSumRow4 + 1} строка");
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
}


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

int ReadInt4(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы: 2 4 | 3 4, 3 2 | 3 3. Результирующая матрица будет: 18 20, 15 18");

int rows5 = ReadInt5("Enter roes number: ");
int columns5 = ReadInt5("Enter columns number: ");
int[,] array5 = new int[rows5, columns5];
int[,] Array2d = new int[rows5, columns5];
int[,] finalArray = new int[rows5, columns5];

FillMatrixRandomNumbers5(array5);
WriteArray2D5(array5);

Console.WriteLine();

FillMatrixRandomNumbers5(Array2d);
WriteArray2D5(Array2d);

Console.WriteLine();

if (array5.GetLength(0) != Array2d.GetLength(1))
{
    Console.WriteLine("Not possible");
    return;
}
for (int i5 = 0; i5 < array5.GetLength(0); i5++)
{
    for (int j5 = 0; j5 < Array2d.GetLength(1); j5++)
    {
        finalArray[i5, j5] = 0;
        for (int g = 0; g < array5.GetLength(1); g++)
        {
            finalArray[i5, j5] += array5[i5, g] * Array2d[g, j5];
        }
    }
}

WriteArray2D5(finalArray);

void FillMatrixRandomNumbers5(int[,] array5)
{
    for(int i5 = 0; i5 < array5.GetLength(0); i5++)
    {
        for(int j5 = 0; j5 < array5.GetLength(1); j5++)
        {
            array5[i5, j5] = new Random().Next(1, 10);
        }
    }
}

void WriteArray2D5(int[,] array5)
{
    for (int i5 = 0; i5 < array5.GetLength(0); i5++)
    {
        for (int j5 = 0; j5 < array5.GetLength(1); j5++)
        {
            Console.Write($"{array5[i5, j5]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt5(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");