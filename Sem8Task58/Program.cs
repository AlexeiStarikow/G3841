// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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
            arr[i, j] = numberSyntezator.Next(1, 10);
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

// Метод находит произведение двух матриц
void Multiply_matrix(int[,] array1, int[,] array2)
{
    int[,] res = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            res[i, j] = array1[i, j] * array2[i, j];
            Console.Write("{0} ", res[i, j]);
        }
        Console.WriteLine();
    }
}


int n1 = ReadData("Введите количество строк первой матрицы ");
int m1 = ReadData("Введите количество столбцов первой матрицы ");
int n2 = ReadData("Введите количество строк второй матрицы ");
int m2 = ReadData("Введите количество столбцов второй матрицы");

int[,] matrix1 = Gen2DArr(n1, m1);
int[,] matrix2 = Gen2DArr(n2, m2);
Console.WriteLine();
Print2DArray(matrix1);
Console.WriteLine();
Print2DArray(matrix2);
Console.WriteLine();
Multiply_matrix(matrix1, matrix2);
