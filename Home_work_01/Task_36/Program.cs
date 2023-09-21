/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 89, 6] -> 85   */

int[] GetArray(int Length, int minValue = -20, int maxValue = 20)  

{
    int[] array = new int[Length];                             

        for (int i = 0; i < array.Length; i++)
        {
        array[i] = new Random().Next(minValue, maxValue + 1);
        }
        return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)    
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}                                       


int SumOdd (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            sum = sum + array[i];
    }
    return sum;

}

int[] massive = GetArray(8);
PrintArray(massive);
Console.WriteLine(SumOdd(massive));
