/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76  */

double[] GetArray(int Length, int minValue = -20, int maxValue = 20)  

{
    double[] array = new double[Length];                             

        for (int i = 0; i < array.Length; i++)
        {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
        return array;
}

void PrintArray(double[] array)
{
    foreach (var item in array)    
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}           

double FindMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double FindDiff(double maxDigit, double minDigit)
{
   double diff = maxDigit - minDigit;
   return diff;
}

double[] massive = GetArray(5);
PrintArray(massive);
double max = FindMax(massive);
double min = FindMin(massive);

double difference = FindDiff(max, min);
Console.WriteLine($"{difference:f}");
