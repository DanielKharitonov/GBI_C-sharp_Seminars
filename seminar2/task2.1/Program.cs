// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру в числе

Random rand = new Random(); // Объявление объекта класса Random
int randNumber = rand.Next(10, 100); // Генерация переменной от 10 до 99 - [10;100) - полуоткрытый интервал, а не закрытый (так исторически сложилось)
// int randNumber = new Random().Next(10,100);

System.Console.WriteLine(randNumber);

Console.Clear();

if (randNumber / 10 > randNumber % 10)
{
    System.Console.WriteLine($"Большая цифра числа {randNumber}: {randNumber / 10}");
}
else
{
    System.Console.WriteLine($"Большая цифра числа {randNumber}: {randNumber % 10}");
}