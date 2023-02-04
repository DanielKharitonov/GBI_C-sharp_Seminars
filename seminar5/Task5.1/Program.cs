// Задача 31. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9,9]. Найдите сумму
// отрицательных и положительных чисел.

Console.Clear();

int[] FillArrayRandomNumbers(int size, int leftRange, int rihtRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rihtRange + 1);
    }
    return array;
}

void SumPisitiveAndNegativeElements(int[] array, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP = sumP + array[i];
        }
        else
        {
            sumN = sumN + array[i];
        }
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("Массив: [" + string.Join(",", array) + "]");    
}

int[] array = FillArrayRandomNumbers(12, -9, 9);
PrintArray (array);

SumPisitiveAndNegativeElements(array,out int sumP, out int sumN);
System.Console.WriteLine($"Сумма положительных чисел массива:{sumP}");
System.Console.WriteLine($"Сумма положительных чисел массива:{sumN}");