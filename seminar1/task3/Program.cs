﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = N * -1;
while (M <= N)
{
    Console.WriteLine(M);
    M += 1;
}
