// Тернарные операторы

Console.Clear();
int x=2;
int y=7;

// Обычное решение:
// if(x>y)
// {
//     System.Console.WriteLine(x+y);
// }
// else
// {
//     System.Console.WriteLine(x*y);
// }

int z=x>y ? (x+y) : (x*y);
System.Console.WriteLine(z);