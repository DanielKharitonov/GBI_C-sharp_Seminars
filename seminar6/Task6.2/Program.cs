// Задача 40: Напишите программу, которая принимает на воход 
// три числа и проверяет, может ли существовать треугольник
// с сторонами такой длины

Console.Clear();

double EnterNumber(string message)
{
    double number;
    while (true)
    {
        System.Console.Write(message);
        if (!(double.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else
        {
            break;
        }
    }
    return number;
}

double[] EnterNumbers(uint numbers)
{
    System.Console.WriteLine($"Введите {numbers} чисел(ла):");
    System.Console.WriteLine();
    double[] arrayNumbers = new double[numbers];
    for (int i = 0; i < numbers; i++)
    {
        arrayNumbers[i] = EnterNumber($"Введите {i + 1}-е число: ");
    }
    System.Console.WriteLine();
    return arrayNumbers;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("|", array) + "]");
}

void ExistenceTriangle(double[] numbers)
{
    if (numbers[0] < numbers[1] + numbers[2] && numbers[1] < numbers[0] + numbers[2] && numbers[2] < numbers[1] + numbers[0])
    {
        System.Console.WriteLine("Треугольник с заданными длинами сторон существует");
    }
    else
    {
        System.Console.WriteLine("Треугольник с заданными длинами сторон НЕ существует");
    }
}

double[] numbers = EnterNumbers(3);
PrintArray(numbers);
System.Console.WriteLine();
ExistenceTriangle(numbers);