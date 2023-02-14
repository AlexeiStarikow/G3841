// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печатает результат
void PrintResult(int msg)
{
    Console.WriteLine(msg);
}

// Метод считает сумму чисел от M до N
int SumRecMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + SumRecMN(m + 1, n);
    }
}

int numM = ReadData("Введите число М: ");
int numN = ReadData("Введите число N: ");
PrintResult(SumRecMN(numM, numN));