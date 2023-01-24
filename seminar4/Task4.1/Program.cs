// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

int Sum(int number) // Методы писать с большой буквы
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int InputNumber(string message)
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

int A = InputNumber("Введите число А: ");
int B = InputNumber("Введите число B: ");

int sumA=Sum(A);
int sumB=Sum(B);

System.Console.WriteLine($"Сумма чисел от 1 до {A}: {sumA}");
System.Console.WriteLine($"Сумма чисел от 1 до {B}: {sumB}");