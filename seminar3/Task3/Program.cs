// AB = √((xb - xa)^2 (yb - ya)^2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

System.Console.WriteLine("Введите координату x1 первой точки:");
int x1= Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату y1 первой точки:");
int y1= Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату x2 первой точки:");
int x2= Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату y2 первой точки:");
int y2= Convert.ToInt32(System.Console.ReadLine());

double distance = Math.Sqrt((Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));

System.Console.WriteLine(distance);