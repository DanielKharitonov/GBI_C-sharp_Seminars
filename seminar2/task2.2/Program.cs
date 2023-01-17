// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();

Random rand = new Random(); 
int randNumber = rand.Next(100, 1000); 

System.Console.WriteLine(randNumber);

// int randNumber1 = randNumber / 100;
// int randNumber2 = randNumber % 10;
// System.Console.WriteLine($"{randNumber1}{randNumber2}");

int newNumber = (randNumber/100)*10+randNumber%10;