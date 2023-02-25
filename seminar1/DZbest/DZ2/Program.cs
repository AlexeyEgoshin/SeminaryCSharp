// int Prompt(string message)
// {
//     System.Console.Write($"{message} >");
//     return Convert.ToInt32(Console.ReadLine());
// }
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int a = 2;
// int b = 3;
// int c = 7;

 int Prompt(string message)
 {
     System.Console.Write($"{message} >");
     return Convert.ToInt32(Console.ReadLine());
}

int a = Prompt("Введите первое число ");
int b = Prompt("Введите второе число ");
int c = Prompt("Введите третье число ");
int max = 0;

if (a > b & a > c)
{
    max = a;
}
else if (b > a & b > c)
{
    max = b;
}
else 
{
    max = c;
}

System.Console.WriteLine($"Максимальное число {max}");