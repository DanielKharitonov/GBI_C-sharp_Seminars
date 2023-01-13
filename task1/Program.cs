// dotnet - проверка, все ли установлено
// dotnet console - создание проекта
// dotnet run - запуск проекта

Console.Write("Введите целое число: "); // Вывод в консоль сообщения
int number = Convert.ToInt32(Console.ReadLine()); // int.Parse() & Convert.ToInt32()
int sqr = number * number;
System.Console.WriteLine($"Квадрат числа: {sqr} вот!"); // ("Квадрат числа: + sqr + далее текст")
