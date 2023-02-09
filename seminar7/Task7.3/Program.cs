// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которорых оба индекса нечетные, и замените эти элементы
// на их квадраты.

Console.Clear();

int[,] MatrixSumIndex(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = i + j;
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

int[,] GhangeMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                matrix[i, j] = (int) Math.Pow(matrix[i, j],2);
            }
        }
    }
    return matrix;
}

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = MatrixSumIndex(m, n);
System.Console.WriteLine();

PrintMatrix(matrix);
System.Console.WriteLine();

int[,] ghangeMatrix = GhangeMatrix(matrix);
PrintMatrix(ghangeMatrix);
