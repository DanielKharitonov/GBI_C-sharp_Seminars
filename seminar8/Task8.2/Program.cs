// задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. 

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
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}

int[,] MatrixChange(int[,] matrix)
{
    int[,] matrixChange = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrixChange.GetLength(0); i++)
    {
        for (int j = 0; j < matrixChange.GetLength(1); j++)
        {
            matrixChange[i, j] = matrix[j, i];
        }
    }
    return matrixChange;
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

MatrixChange(matrix);
int[,] matrixChange = MatrixChange(matrix);
PrintMatrix(matrixChange);

