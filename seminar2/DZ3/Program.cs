// Задача 2: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6




int number = ReadInt("Введите число ");

if (number < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
System.Console.WriteLine(InCenter(number));    
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
while (a >= 1000)
{
    a = a / 10;
}
a = a % 10;
return a;
}