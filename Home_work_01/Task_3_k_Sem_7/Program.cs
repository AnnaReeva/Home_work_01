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

double [] FindAverageInColumns (int [,] matrix)
{
    double[] = new double[n];
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[j.i];
        }
        
    }


}