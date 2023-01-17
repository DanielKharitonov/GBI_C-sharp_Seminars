// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(Number1,2)==Number2 || Math.Pow(Number2,2)==Number1) // && - and, || - or
{
    System.Console.WriteLine("Одно число является квадратом другого");
}
else
{
    System.Console.WriteLine("Одно число НЕ является квадратом другого");
}