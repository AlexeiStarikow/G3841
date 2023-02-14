// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печатает результат
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return LineGenRec(num - 1) + " " + num;
    }
}

int number=ReadData("Введите число: ");
string resultLine=LineGenRec(number);
PrintResult(resultLine);