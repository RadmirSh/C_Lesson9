// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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