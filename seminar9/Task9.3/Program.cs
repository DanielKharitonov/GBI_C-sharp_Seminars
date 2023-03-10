// Задача 67: Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int Sum(int numb)
{

    if (numb == 0)
    {
        return 0;
    }
    return numb % 10 + Sum(numb / 10);
}

System.Console.WriteLine($"{Sum(453)}");