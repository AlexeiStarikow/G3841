// Задача 68: Напишите программу
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int m=ReadData("Введите число M: ");
int n=ReadData("Введите число N: ");

///Метод вычисления функции Аккермана:
int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
return AckermanFunction(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел {m},{n} = {AckermanFunction(m, n)}");