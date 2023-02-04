// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве


Console.Clear();

int[] FillArrayRandomNumbers(uint size, int leftBorder, int rihtBorder)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftBorder, rihtBorder + 1);
    }
    return array;
}

string YesOrNoNumberInArray(int[] array, int number)
{
    string answer = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            answer = "Веденное число есть в массиве";
            break;
        }
        else
        {
            answer = "Введенного числа нет в массиве";
        }
    }
    return answer;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int EnterNumber(string message)
{
    int number;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
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

uint EnterNumberNatur(string message)
{
    uint number;
    while (true)
    {
        System.Console.Write(message);
        if (!(uint.TryParse(Console.ReadLine(), out number)))
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


uint size = EnterNumberNatur("Введите размер массива:");
int leftBorder = EnterNumber("Введите зачение левой границы интервала выборки для заполнения массива: ");
int rigthBorder = EnterNumber("Введите зачение левой границы интервала выборки для заполнения массива: ");

if (leftBorder > rigthBorder)
{
    System.Console.WriteLine("Правая граница интервала выборки должна быть меньше левой! Повторите ввод.");
}
else
{
    int number = EnterNumber("Введите число:");
    int[] array = FillArrayRandomNumbers(size, leftBorder, rigthBorder);
    System.Console.WriteLine($"Массив:");
    PrintArray(array);
    string answer = YesOrNoNumberInArray(array, number);
    System.Console.WriteLine(answer);
}
