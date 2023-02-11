// Задача №53
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

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

// Метод меняет верхнуюю и нижнюю стоки массива
void SwapRaw2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp=arr[0,i];
        arr[0,i]=arr[arr.GetLength(0)-1,i];
        arr[arr.GetLength(0)-1,i]=temp;
    }
}


int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");
Console.WriteLine();
int[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
SwapRaw2DArray(matrix);
Console.WriteLine();
Print2DArray(matrix);