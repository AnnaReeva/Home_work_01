/* Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

Пример


n = 3;
m = 4;
k = 2;
x = 8;
y = 3;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);


1   3   5   7   
9   11  13  15  
17  19  21  23  
There is no such index


n = 4;
m = 5;
k = 3;
x = 2;
y = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);


1   4   7   10  13  
16  19  22  25  28  
31  34  37  40  43  
46  49  52  55  58  
The number in [2, 2] is 19
*/


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


int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{
    int[] array = new int[2];
    if (rowPosition > matrix.GetLength(0) - 1 || columnPosition > matrix.GetLength(1) - 1)
        { 
            array[0] = 0;
            array[1] = 0;
        }
    else
        array[0] = matrix[rowPosition,columnPosition];
        array[1] = 0;
    return array;   
}

void PrintCheckIfError (int[] results, int X, int Y)
{
    
}

int[,] arr = CreateIncreasingMatrix(3, 4, 2);
PrintArray(arr);

int[] rez2 = FindNumberByPosition(arr, 2, 2);
PrintCheckIfError(rez2, 2,2);