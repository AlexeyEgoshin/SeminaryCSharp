// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int value1 = Prompt("Введите первое число");
int value2 = Prompt("Введите второе число");

int max = 0;
int min = 0;
if (value1 > value2)
{
    max = value1;
    min = value2;
}
else
{
    max = value2;
    min = value1;
}

System.Console.WriteLine($"Минимальное число {min} , а максимальное число {max}.");