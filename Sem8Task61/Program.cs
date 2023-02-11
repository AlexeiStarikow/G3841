// Задача №61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника

// Метод вычисляет факториал
float Factor(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит треугольник Паскаля
void PrintPascalTriangle(int nRaw)
{
    for (int i = 0; i < nRaw; i++)
    {
        for (int j = 0; j <= nRaw - i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();
    }
}

int countRaw=ReadData("Введите количество строк треугольника Паскаля");
PrintPascalTriangle(countRaw);