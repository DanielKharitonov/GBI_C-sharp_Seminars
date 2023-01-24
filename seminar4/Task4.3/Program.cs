// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено не число");
    }
    return number;
}

void Factorial(int count)
{
    int answer = 1;
    for (int i = 1; i < count + 1; i++)
    {
        answer *= i;
    }
    System.Console.WriteLine(answer);
}

int N = InputNumber("Введите число N:");
Factorial(N);