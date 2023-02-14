// Задача 67
// Програма принимает на вход число и возвращает сумму числа

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печатает результат
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}


// Сумма цифр в числе рекулентно
int RecSumDig(int n)
{
    if(n<=10)return n;
    return n%10+RecSumDig(n/10);
}

int numN= ReadData("Введите число N: ");
int sum=RecSumDig(numN);
PrintResult(sum);