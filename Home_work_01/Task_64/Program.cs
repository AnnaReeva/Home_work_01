/* Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

void AllNatural(int n, int start = 1)
{
    if (n < start)
        return;
    if (n == start) 
    {
        Console.Write(start);
        return;
    }

    Console.Write(n + ", ");

    AllNatural(n - 1, start);
}

AllNatural(5);