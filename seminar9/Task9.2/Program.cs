// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от M до N

Console.Clear();

void PrintFromNumberToOne(int numb1, int numb2)
{
    if (numb2 > numb1)
    {
        PrintFromNumberToOne(numb1, numb2 - 1);
    }
    Console.WriteLine(numb2);
}

PrintFromNumberToOne(4,8);