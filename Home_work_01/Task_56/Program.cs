/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.  */

using System.Diagnostics.CodeAnalysis;

int[,] GetArray(int rows, int cols, int minValue = 1, int maxValue = 10)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1) ;
        }
    }
    return array;
}

int RowWithMinSum(int[,] array)
{
    int minSum = 0;
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[i, j];
    }

    for (i = 1; i < array.GetLength(0); i++)
    { 
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
            minSum = sum;
    }

    return minSum;
}


void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int [,] array = GetArray(3, 4);
PrintArray(array);
Console.WriteLine(RowWithMinSum(array));
