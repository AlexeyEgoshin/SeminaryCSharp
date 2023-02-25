// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
//string[] week = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
//while (true)
//{
//System.Console.WriteLine("Введите число от 1 до 7");
//int userNumber = Convert.ToInt32(Console.ReadLine());
//if (userNumber < 1 || userNumber > 7)
//{
//    System.Console.WriteLine("Вы ввели не правильное число попробуйте еще раз");
//}
//else
//{
//    int weekIndex = userNumber - 1;
//    System.Console.WriteLine($"Вы ввели число {userNumber} это день недели {week[weekIndex]}");
//    break;
//}
//}

System.Console.WriteLine("Введите день недели ");
int weekDay = Convert.ToInt32(Console.ReadLine());
if (weekDay == 1)
{
System.Console.WriteLine("понедельник");
}

if (weekDay == 2)
{
System.Console.WriteLine("вторник");
}

if (weekDay == 3)
{
System.Console.WriteLine("среда");
}

if (weekDay == 4)
{
System.Console.WriteLine("четверг");
}

if (weekDay == 5)
{
System.Console.WriteLine("пятница");
}

if (weekDay == 6)
{
System.Console.WriteLine("суббота");
}

if (weekDay == 7)
{
System.Console.WriteLine("воскресенье");
}

if (weekDay < 1 || weekDay > 7)
{
    System.Console.WriteLine("такого дня не существует");
}
