/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива */


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

int[,] OrganizeRowFromMaxToMin(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
    for (int k = 0; k < array.GetLength(1) -1; k++)  
        for (int j = 0; j < array.GetLength(1) -1; j++)
        {
            if (array[i, j] < array[i, j +1])
            {
                int temp = array[i, j];
                array[i, j] = array[i, j +1];
                array[i, j +1] = temp;
            }
            
        }
       
    }
    return array;
}

int [,] array = GetArray(4, 6);
PrintArray(array);

int[,] resArray = OrganizeRowFromMaxToMin(array);

PrintArray(resArray);
