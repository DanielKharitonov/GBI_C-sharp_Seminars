// Console.Clear();
// int[] coords = new int[2];
// System.Console.WriteLine("Введите x:");
// coords[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите y:");
// coords[1] = Convert.ToInt32(Console.ReadLine());
// if (coords[0] < 0 && coords[1] > 0)
// {
//     System.Console.WriteLine("Номер четверти - 1");
// }
// else if (coords[0] < 0 && coords[1] < 0)
// {
//     System.Console.WriteLine("Номер четверти - 2");
// }
// else if (coords[0] > 0 && coords[1] < 0)
// {
//     System.Console.WriteLine("Номер четверти - 3");
// }
// else if (coords[0] > 0 && coords[1] > 0)
// {
//     System.Console.WriteLine("Номер четверти - 4");
// }

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

System.Console.WriteLine("Введите номер четверти:");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = { "x>0,y>0", "x>0,y<0", "x<0,y<0", "x<0,y>0", "введено не корректное число" };
switch (num)
{
    case 1:
        System.Console.WriteLine(array[0]);
        break;
    case 2:
        System.Console.WriteLine(array[3]);
        break;
    case 3:
        System.Console.WriteLine(array[2]);
        break;
    case 4:
        System.Console.WriteLine(array[1]);
        break;
    default:
        System.Console.WriteLine(array[4]);
        break;
}
