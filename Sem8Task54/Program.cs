// Задача 54: Задайте двумерный массив.
//  Напишите программу, которая упорядочит 
//  по убыванию элементы каждой строки двумерного массива.

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

// Метод сортирует массив
void Sort2DArr(int[,] arr)
{
    int[] bufA = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            bufA[j] = arr[i, j];
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (bufA[j] > bufA[k])
                {
                    int temp = bufA[k];
                    bufA[k] = bufA[j];
                    bufA[j] = temp;
                }
            }
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = bufA[j];
        }
    }
}

int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");
int[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
Console.WriteLine();
Sort2DArr(matrix);
Print2DArray(matrix);
