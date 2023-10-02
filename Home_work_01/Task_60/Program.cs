/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
  */

int[,,] GetArray(int rows, int cols, int three, int minValue = 10, int maxValue = 99)
{
    int[,,] array = new int[rows, cols, three];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
                if (!IsContain(array,array[i, j, k]))
                    array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
                
        }
    }
    return array;
}


bool IsContain(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element)
                    return true;
            }
        }    
    
    }
    return false;
}

void PrintArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int n = array[i,j,k];
                Console.Write($" {n} ({i}, {j}, {k})");
            }
            Console.WriteLine();    
        }
    }
    Console.WriteLine();
}



int [,,] arrayThree = GetArray(3, 3, 3);
PrintArray(arrayThree);

