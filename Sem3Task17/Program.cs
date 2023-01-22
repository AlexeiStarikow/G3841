// Задача 17
// Напишите программу, которая принимает на вход координаты точки (X,Y) (не равны нулю),
// и выдает номер четверти плоскости, в которой находится эта точка.

int coordX = ReadData("Ввведите координату X");
int coordY = ReadData("Ввведите координату Y");
PrintQuterTest(coordX,coordY);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод определяет четверть по координатам точки
void PrintQuterTest(int X, int Y)
{
    if (X > 0 && Y > 0) Console.WriteLine("Точка в четверти 1");
    if (X > 0 && Y < 0) Console.WriteLine("Точка в четверти 2");
    if (X < 0 && Y < 0) Console.WriteLine("Точка в четверти 3");
    if (X < 0 && Y > 0) Console.WriteLine("Точка в четверти 4");

}