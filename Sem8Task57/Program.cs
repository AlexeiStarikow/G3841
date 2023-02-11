// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.

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

// Метод выводит одномерный массив
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
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

// Метод создает частотный словарь
int[] FillFreqArray(int[,] matr, int alphLen)
{
    int [] farr=new int [alphLen];
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            ++farr[matr[i,j]];
        }
    }
    return farr;
}

int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");
Console.WriteLine();
int[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
Console.WriteLine();
int [] fregDic=FillFreqArray(matrix, 100);
Print1DArray(fregDic);