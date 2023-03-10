// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int InputInt(string message)                // название метода
{
    System.Console.Write($"{message}> ");   // вывод приглашения к вводу
    int value;                                // инициализация переменной
    if (int.TryParse(Console.ReadLine(), out value)) // проверка условия корректности ввода + ввод со строки
    {                                    // TryParse - если конвертация строки прошла правильно, то мы попадаем в ветку
        return value;                    // которая находится в скобках после наименования функции. Если да
    }                                    // то выдает первое значение (ввод со строки). Нет - второе (out)
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                 // Если TryParse не сработало, выходим из программы(Exit) с кодом 1.
    return 0;                            // нужна для компиляции
}

int Number = InputInt("Введите число N, до которого выдадим квадраты: "); // запуск функции ввода числа number

for(int i = 1; i <= Number; i++)   // у цикла for Три параметра: 1- инициализация, 2- условие продолжения, 3- команда в конце каждого цикла
{
    int Square = i * i;            // заводим переменную = квадрату счетчика
    System.Console.Write($"{Square} "); // вывод квадрата на экран в одну
}