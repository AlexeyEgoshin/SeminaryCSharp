// 1. Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.

int InputInt(string message)
{
    System.Console.Write($"{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

bool ValidateCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Одна из координат находится на оси");
        return false;
    }

    return true;
}

int GetQuorter(int x, int y)
{
    if (x > 0 && y > 0)
{
    return 1; // номер четверти
}
    if (x < 0 && y > 0)
{
    return 2;
}
    if (x < 0 && y < 0)
{
    return 3;
}
return 4;
}

int x = InputInt("Введите X");
int y = InputInt("Введите Y");
if (ValidateCoords(x, y))
{
    System.Console.WriteLine($"Координаты {x}, {y} находятся в четверти {GetQuorter(x, y)}");
}