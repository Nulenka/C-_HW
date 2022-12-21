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
}

int ReadInt3(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

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


Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2: 66(0,0,0) 25(0,1,0), 34(1,0,0) 41(1,1,0), 27(0,0,1) 90(0,1,1), 26(1,0,1) 55(1,1,1)");

int[,,] Matrix3D = new int[2, 2, 2];
FillMatrix3d(Matrix3D);
WriteIndex(Matrix3D);

void WriteIndex(int[,,] Matrix3D)
{
    for (int i6 = 0; i6 < Matrix3D.GetLength(0); i6++)
    {
        for (int j6 = 0; j6 < Matrix3D.GetLength(1); j6++)
        {
            Console.WriteLine();
            for (int w = 0; w < Matrix3D.GetLength(2); w++)
            {
                Console.Write($"{Matrix3D[i6, j6, w]}({i6},{j6},{w}) ");
            }
        }
    }
    Console.WriteLine(" ");
}

void FillMatrix3d(int[,,] Matrix3D)
{
    int count6 = 10;
    for (int i6 = 0; i6 < Matrix3D.GetLength(0); i6++)
    {
        for (int j6 = 0; j6 < Matrix3D.GetLength(1); j6++)
        {
            for (int w = 0; w < Matrix3D.GetLength(2); w++)
            {
                Matrix3D[w, i6, j6] += count6;
                count6 += 3;
            }
        }
    }
}
Console.WriteLine(" ");

Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив: 01 02 03 04, 12 13 14 05, 11 16 15 06, 10 09 08 07");

int sideLong = 4; //int n = 4;
int[,] sqrArray = new int[sideLong, sideLong]; //int[,] sqareMatrix = new int[n, n];

int temp7 = 1;
int i7 = 0;
int j7 = 0;

while (temp7 <= sqrArray.GetLength(0) * sqrArray.GetLength(1))
{
  sqrArray[i7, j7] = temp7;
  temp7++;
  if (i7 <= j7 + 1 && i7 + j7 < sqrArray.GetLength(1) - 1)
    j7++;
  else if (i7 < j7 && i7 + j7 >= sqrArray.GetLength(0) - 1)
    i7++;
  else if (i7 >= j7 && i7 + j7 > sqrArray.GetLength(1) - 1)
    j7--;
  else
    i7--;
}

WriteArray7(sqrArray);

void WriteArray7(int[,] array7)
{
    for (int i7 = 0; i7 < array7.GetLength(0); i7++)
    {
        for (int j7 = 0; j7 < array7.GetLength(1); j7++)
        {
            if (array7[i7, j7] / 10 <= 0)
            {
                Console.Write($" {array7[i7,j7]} ");
                Console.Write(" ");
            }
            else Console.Write($"{array7[i7,j7]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine(" ");
Console.WriteLine("Thanks for checking!");
Console.WriteLine(" ");