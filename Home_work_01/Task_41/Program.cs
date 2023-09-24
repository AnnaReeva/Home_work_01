/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3   */


int FindCounInM(int m)
{
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
        count +=1;   
}

Console.WriteLine($"Пользователь ввел {count} числа больше нуля");
return count;
}

FindCounInM(3);
