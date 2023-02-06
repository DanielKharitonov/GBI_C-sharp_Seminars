// Задча 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное

Console.Clear();

int EnterNumber(string message)
{
    int number;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено десятичное число, попробуйте еще раз.");
        }
        else
        {
            break;
        }
    }
    return number;
}

void GetBinaryView(int numb)
{
    if(numb<=0) return;
    GetBinaryView(numb/2);
    System.Console.Write(numb%2);
}

int N = EnterNumber("Введите число: ");
GetBinaryView(N);
System.Console.WriteLine();