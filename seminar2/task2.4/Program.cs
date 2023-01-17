//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();

System.Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Number1 = 7;
int Number2 = 23;

if (Number % Number1 == 0 && Number % Number2 == 0) // && - и, ...
{
    System.Console.WriteLine($"Введенное число {Number} кратно {Number1} и {Number2}");
}
else
{
    System.Console.WriteLine($"Введенное число не кратно {Number1} и {Number2}");
}