// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от 1 до N

Console.Clear();

void PrintFromNumberToOne(int numb)
{
    if (numb > 1)
    {
        PrintFromNumberToOne(numb - 1);
    }
    Console.WriteLine(numb);
}

PrintFromNumberToOne(5);