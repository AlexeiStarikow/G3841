// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод создает массив
int[,,] Create3DArray(int raw, int col, int dep)
{
    int[,,] arr = new int[raw, col, dep];

    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
    return arr;
}

// Метод выводит массив с индексами
void PrintInd3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }

}

int a = ReadData("Введите количество строк первой матрицы ");
int b = ReadData("Введите количество столбцов первой матрицы ");
int c = ReadData("Введите количество строк второй матрицы ");

int [,,] matr=Create3DArray(a,b,c);
PrintInd3DArray(matr);