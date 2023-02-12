// / Задача 62. Напишите программу,
//  которая заполнит спирально массив 4 на 4.

int rawCol = ReadData("Введите размер матрицы: ");
int[,] matr = ArrSpiral(rawCol);
Print2DArray(matr);

// Метод заполнения массива спирально

int[,] ArrSpiral(int n)
{
    int[,] arr = new int[n, n];
    int num = 1;
    for (int delta = 0; delta < n - 2; delta++)
    {
        for (int i = 0 + delta; i < n - delta; i++)
        {
            arr[0 + delta, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + delta; i < n - delta; i++)
        {
            arr[i, n - 1 - delta] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - delta; i >= 0 + delta; i--)
        {
            arr[n - 1 - delta, i] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - delta; i >= 1 + delta; i--)
        {
            arr[i, 0 + delta] = num;
            num++;
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
           if(array[i,j]<10)
           {
             Console.Write($" {array[i, j]} ");
           }
           else
           {
             Console.Write(array[i, j] + " ");
           }


        }
        Console.WriteLine();

    }

}

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
