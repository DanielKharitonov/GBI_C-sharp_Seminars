// Задача 48: Задайте двемерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
// Amn = m+n. Выведите полученный массив на экран.

Console.Clear();

int[,] MatrixSumIndex (int rows, int cols)
{
    int[,] matrix = new int [rows,cols];

for (int i=0; i<rows;i++)
{
    for (int j=0;j<cols;j++)
    {
        matrix[i,j]=i+j;
    }
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0;j<matrix.GetLength(1);j++)
    {
        System.Console.Write(matrix[i,j]+"\t");
    }
    System.Console.WriteLine();
}
}

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = MatrixSumIndex(m,n);
System.Console.WriteLine();

PrintMatrix(matrix);