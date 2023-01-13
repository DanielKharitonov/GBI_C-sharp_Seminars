// Напишите программу, которая принимает на вход число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (99 < numb && numb < 1000)
{
    Console.WriteLine("Введено трехзначное число");
    int answer = numb % 10;
    Console.WriteLine($"Последняя цифра числа: {answer}");
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}
