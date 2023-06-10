// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Please write the number of the task: 1 or 2");

int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        task1();
        break;

    case 2:
        task2();
        break;

    default:
        break;
}

void task1()
{
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
}

void task2()
{
    Console.Write("Please write the number M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please write the number N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int functionOfAkkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return functionOfAkkerman(m - 1, 1);
        else return functionOfAkkerman(m - 1, functionOfAkkerman(m, n - 1));
    }

    Console.Write($"The function of Akkerman is {functionOfAkkerman(m, n)} ");
}