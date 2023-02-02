// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины

// Метод вывода
// void PrintData(string msg1, double msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);

// }

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод проверяет на треугольник
void CheckTr(int n1, int n2, int n3)
{
    if ((n1 + n2) > n3 || (n2 + n3) > n1 || (n1 + n3) > n2)
    {
        Console.WriteLine("Треугольник возможен");
    }
    else
    {
        Console.WriteLine("Треугольник невозможен");
    }
}

int a = ReadData("Введите первое число");
int b = ReadData("Введите второе число");
int c = ReadData("Введите третье число");
CheckTr(a, b, c);