//Задача: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.WriteLine ($"Input natural number: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 1;
RecuNum(m, count);

void RecuNum(int m, int count)
{
    if (count > m) return;
    else
    {
        RecuNum(m, count + 1);
        Console.Write(count + " ");
    }
}
*/

//Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SumBtwMAndN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int count = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        count = m + SumMN(m, n);
        return count;
    }
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumBtwMAndN(m, n);
