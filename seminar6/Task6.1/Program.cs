// Задача 39. Напишите программу, которая перевернет одномерный
// массив (последний элемент будет на первом месте, а первый - 
// на послденем и т.д)

Console.Clear();

int[] FillArrayRandomNumbers(uint size, int leftBorder, int rightBorder)
{
    int[] array = new int[size];
    if (leftBorder < rightBorder)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(leftBorder, rightBorder + 1);
        }
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(rightBorder, leftBorder + 1);
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

void ReverseArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int[] array = FillArrayRandomNumbers(10, 0, 10);
PrintArray(array);
System.Console.WriteLine();
ReverseArray(array);
PrintArray(array);




