// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

// Метод поиска минимального элемента
(int x, int y) SearchMinElem(int[,] matr)
{
    int raw = 0;
    int col = 0;
    int minElem = int.MaxValue;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minElem > matr[i, j])
            {
                raw = i;
                col = j;
                minElem = matr[i, j];
            }
        }
    }
    return (raw, col);
}

// Метод удаляет строку и столбец содержащий минимальный элемент

int[,] Update2DArray(int[,] matr, int x, int y)
{
    int[,] resArr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];

    int k = 0;
    int m = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                resArr[k, m] = matr[i, j];
            }
            if (j != y)
            {
                m++;
            }
        }
        if (i != x)
        {
            k++;
        }
    }
    return resArr;
}

int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");
int[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
Console.WriteLine();
(int x, int y) minElem=SearchMinElem(matrix);

int[,] newMatrix=Update2DArray(matrix, minElem.x,minElem.y);

Print2DArray(newMatrix);
