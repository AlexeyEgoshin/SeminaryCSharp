// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

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

double Distance(int x1, int y1, int x2, int y2) // Прописываем функцию поиска расстояния между точками. я
{                                               // Координаты точек передаются в качестве аргументов функции
    int DeltaX = x2 - x1;                       // Вводим переменную, считающую расстояние по координате х
    int DeltaY = y2 - y1;                       // Вводим переменную, считающую расстояние по координате у
    return Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY); // Функция возвращает значение  = квадратный корень из суммы квадратов катетов (Пифагор)
}
int  x1 = InputInt($"Введите координату x первой точки: "); // запускаем функцию ввода для координаты х1
int  y1 = InputInt($"Введите координату y первой точки: "); // запускаем функцию ввода для координаты у1
int  x2 = InputInt($"Введите координату x второй точки: "); // запускаем функцию ввода для координаты х2
int  y2 = InputInt($"Введите координату y второй точки: "); // запускаем функцию ввода для координаты у2

System.Console.WriteLine($"Расстояние между точкой А({x1}, {y1}) и B({x2}, {y2}) равно {Distance(x1, y1, x2, y2):F2}");
        // в качестве аргумента встроенной функции вывода вызвали функцию Distance с 4 введенными координатами