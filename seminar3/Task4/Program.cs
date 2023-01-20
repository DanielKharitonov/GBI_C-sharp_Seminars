// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

System.Console.WriteLine("Введите число N: ");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number>0)
{
   for (int i = 1; i <= Number; i++)
{
    int Num = i*i;
    System.Console.Write($"{Num} ");
} 
}
else
{
    System.Console.WriteLine("Введено отрицательное число");
}