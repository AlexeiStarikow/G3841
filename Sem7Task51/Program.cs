// Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерирует двухмерный массив
int[,] Gen2DArr(int raw, int col)
{
    int[,] arr = new int[raw, col];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = i + j;
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

// Метод меняет массив
int Diagsum(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    for (int i = 0; i < min; i = i + 2)
    {
        res = res + arr[i, i];
    }

    return res;
}


int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");

int[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
int sumDiagonal=Diagsum(matrix);
Console.WriteLine(sumDiagonal);