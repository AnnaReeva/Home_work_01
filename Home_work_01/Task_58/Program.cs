/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.*/


int[,] GetMatrix(int rows, int cols, int minValue = 1, int maxValue = 10)
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


void PrintMatrix(int [,] array)
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



int[,] ProductTwoMatrixes(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
        throw new Exception("Матрицы нельзя перемножить");
        
        
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        res[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
                }
            }
    return res;
        
}

int [,] matrix1 = GetMatrix(3, 4);
int [,] matrix2 = GetMatrix(4, 3);
int [,] matrixRes = ProductTwoMatrixes(matrix1, matrix2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
PrintMatrix(matrixRes);

