// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Please write the number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please write the number N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumOfNumbers(m, n);

void SumOfNumbers(int m, int n)
{
    int SummaMN(int m, int n)
    {
        int res = m;
        if (m == n)
        return 0;
        else
        {
            m++;
            res = m + SummaMN(m, n);
        return res;
        }
    }
    Console.Write($"The sum of natural elements are {SummaMN(m - 1, n)} ");
}


