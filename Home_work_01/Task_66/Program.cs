
/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */


int SumNaturalBetween(int m, int n)
{
    // int sum = 0;
    if (m > n)
        return 0;

    if (m == n)
        return m; 
   
    return n + SumNaturalBetween(m, n -1);
}   

Console.WriteLine(SumNaturalBetween(1, 15));
