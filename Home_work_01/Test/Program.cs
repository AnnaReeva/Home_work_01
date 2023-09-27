
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int current_number = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        { 
           matrix[i, j] = current_number; 
           current_number += k;
        }
        
    }
    
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] matrix = CreateIncreasingMatrix(3, 4, 2);
PrintArray(matrix);

int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{
    int number = matrix[rowPosition,columnPosition];
    int[] array = new int[2];
    if (rowPosition > matrix.GetLength(0))
        {
            array[0] = 0;
            array[1] = 0;
        }
    if (columnPosition > matrix.GetLength(0))
        {
            array[0] = 0;
            array[1] = 0;
        }

    else
        {
            array[0] = number;
            array[1] = 0;
        }
    return array;   
}

int[] arrrez = FindNumberByPosition(matrix,5,2);

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        
        Console.Write(arr[i] + " ");
        
    }
}

PrintArr(arrrez);