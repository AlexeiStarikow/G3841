// Задача №46
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.


// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерирует двухмерный массив
int[,] Gen2DArr(int countRow, int countColum)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColum];
    while (i < countRow)
    {
        j = 0;
        while (j < countColum)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }

    return outArray;
}

// Метод выводит двухмерный массив

void Print2DArray(int[,] array)
{
    int i = 0; int j = 0;
    while (i < array.GetLength(0))
    {
        j = 0;
        while (j < array.GetLength(1))
        {

            Console.Write(array[i, j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }


}

int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");

int[,] matix = Gen2DArr(n, m);
Print2DArray(matix);