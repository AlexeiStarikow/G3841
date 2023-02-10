// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};

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
            outArray[i, j] = numberSyntezator.Next(1, 10);
            j++;
        }
        i++;
    }

    return outArray;
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


// Метод ищет элемент 
void SearchElem(int[,] arr, int elem)
{
    bool elemFind = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (elem == arr[i, j])
            {
                Console.WriteLine($"Элемент в {i} строке и {j} слолбце");
                elemFind = true;
                break;
            }

        }

    }
    if (elemFind == false)
    {
        Console.WriteLine("Элемент не найден");
    }

}

int n = ReadData("Введите количество строк ");
int m = ReadData("Введите количество столбцов ");
int e = ReadData("Введите элемент");


int[,] matrix = Gen2DArr(n, m);
Print2DArray(matrix);
SearchElem(matrix, e);