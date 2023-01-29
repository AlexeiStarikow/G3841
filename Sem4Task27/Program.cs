// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит результат
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// Метод считает сумму цифр в числе
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

// Метод подсчета через строку
int SumDigStr(int num2)
{
    // Переводим в строку;
    string str = num2.ToString();
    int sumStr = 0;
    for (int i = 0; i < str.Length; i++)
    {
        string str2 = Convert.ToString(str[i]);
        sumStr += int.Parse(str2);
    }
    return sumStr;
}

DateTime d1 = DateTime.Now;
int number = ReadData("Введите число: ");
int sum = SumDigit(number);
PrintData("Сумма цифр в числе равна ", sum);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int sum2 = SumDigStr(number);
PrintData("Сумма цифр в числе через строку равна: ", sum2);
Console.WriteLine(DateTime.Now - d2);

if (d1 > d2)
{
    Console.WriteLine("Метод через строку работает медленее");
}
else
{
    Console.WriteLine("Метод через строку работает быстрее");

}

