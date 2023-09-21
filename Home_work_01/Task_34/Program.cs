/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArray(int Length, int minValue = 100, int maxValue = 999)  

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

int CountEvenNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;

}

int[] massive = GetArray(8);
PrintArray(massive);   

Console.WriteLine(CountEvenNumber(massive));
