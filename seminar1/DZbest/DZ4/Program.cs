// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число.");

int inValue = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (number <= inValue)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number++;
}