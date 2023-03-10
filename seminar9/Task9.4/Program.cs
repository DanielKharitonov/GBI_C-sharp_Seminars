// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А в
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int NumberInPower(int numb1, int numb2)
{

    if (numb2 > 1)
        return numb1 * NumberInPower(numb1, numb2 - 1);
    return numb1;
}

System.Console.WriteLine($"{NumberInPower(5, 3)}");
