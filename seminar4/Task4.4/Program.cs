// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.Clear();

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int i = 0;
    while (i < lenght)
    {
        collection[i] = new Random().Next(0, 2);
        i++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
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
            if (number < 0)
            {
                System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
            }
            else
            {
                break;
            }

        }
    }
    return number;
}

int volum = InputNumber("Введите размер массива: ");
int[] array = new int[volum];
FillArray(array);
System.Console.WriteLine("Массив:");
PrintArray(array);