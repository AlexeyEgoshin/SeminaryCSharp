// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите целое число.");

string inValue;

inValue = Console.ReadLine();
int value = Convert.ToInt32(inValue);
if (value % 2 == 0)
{
    System.Console.WriteLine($"Число {value} , является четным.");
}
else
{
   System.Console.WriteLine($"Число {value} , не является четным."); 
}

