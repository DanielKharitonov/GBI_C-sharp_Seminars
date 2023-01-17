// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 % Number2 == 0)
{
    System.Console.WriteLine("Введены кратные числа");
}
else
{
    System.Console.WriteLine($"Остаток от деления чисел: {Number1 % Number2}");
}
