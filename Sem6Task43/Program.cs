// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
// Пример
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Метод вывода
void PrintData(string msg1, double msg2, double msg3)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
    Console.WriteLine(msg3);
}

// Метод считывает данные
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

double b1 = ReadData("Введите b1 ");
double k1 = ReadData("Введите k1 ");
double b2 = ReadData("Введите b2 ");
double k2 = ReadData("Введите k2 ");

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

PrintData("Прямые пересекаются в точке с координатами X,Y", x, y);

