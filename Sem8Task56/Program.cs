// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерирует двухмерный массив
int[,] Gen2DArr(int raw, int col)
{
    System.Random numberSyntezator = new System.Random();
    int[,] arr = new int[raw, col];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = numberSyntezator.Next(1, 100);
        }
    }

    return arr;
}

// Метод выводит двухмерный массив
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();

    }

}

// Метод находит строку массива с наименьшей суммой
int MinSum2DArray(int[,] array)
{
    int min = int.MaxValue;
    int buf = 0;
    int numRaw=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            buf += array[i, j];
        }
        if (buf < min) min = buf;numRaw=i;
    }
    return numRaw;
}

int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");
int[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
Console.WriteLine();
int res=MinSum2DArray(matrix);
Console.WriteLine(res);
