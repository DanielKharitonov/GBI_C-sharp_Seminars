Console.Clear();

uint EnterNumberNatur(string messeng)

{
    uint number;
    Console.Write(messeng);
    while (true)
    {
        if (!(uint.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
            Thread.Sleep(1000);
            Console.CursorTop--;
            System.Console.WriteLine("                                               ");
            Console.CursorTop--;
            Console.CursorTop--;
            System.Console.WriteLine("                                               ");
            Console.CursorTop--;
            Console.Write(messeng);
        }
        else
        {
            break;
        }
    }
    return number;

}

int[,] FillMatrix(uint rows, uint cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

uint rows = EnterNumberNatur("Введите количество строк матрицы: ");
uint cols = EnterNumberNatur("Введите количество столбцов матрицы: ");
int[,] matrix = FillMatrix(rows, cols);
System.Console.WriteLine();

System.Console.WriteLine("Задан массив:");
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();

int iMin = 0;
int jMin = 0;
int min = matrix[0, 0];
for (int i = 1; i < matrix.GetLength(0); i++)
{
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            iMin = i;
            jMin = j;
            min = matrix[i, j];
        }
    }
}

System.Console.WriteLine(min);
System.Console.WriteLine();

int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int countI = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int countJ = 0;
    if (i == iMin) continue;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == jMin) continue;
        result[countI, countJ] = matrix[i, j];
        countJ++;
    }
    countI++;
}

PrintMatrix(result);
