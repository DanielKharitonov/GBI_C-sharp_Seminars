// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int NumNumbers(string message)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(message);
        text = System.Console.ReadLine()!;
        if (!(int.TryParse(text, out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else
        {
            number = text.Length;
            break;
        }
    }

    return number;
}

int N = NumNumbers("Введите число: ");

System.Console.WriteLine($"Количество цифр в числе: {N}");
