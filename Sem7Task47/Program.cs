// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерирует двухмерный массив
double[,] Gen2DArr(int raw, int col)
{
    System.Random numberSyntezator = new System.Random();
    double[,] arr = new double[raw, col];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = numberSyntezator.Next(1, 10) + numberSyntezator.NextDouble();
        }
    }

    return arr;
}
// Метод выводит двухмерный массив
void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor=col[new System.Random().Next(0,16)];
            Console.Write(array[i, j] + " ");
            Console.ResetColor();

        }
        Console.WriteLine();

    }
}

int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");

double[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
