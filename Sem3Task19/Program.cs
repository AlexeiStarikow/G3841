// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// Варинт1
// Считываем данные пользователя
int n = ReadData("Введите число: ");
// Проверка на пятизначность
if (n > 9999 && n < 100000)
{
    // Проверяем на палиндром
    if (PalinTest(n) == true)
    {
        PrintData("Число является палиндромом.");
    }
    else
    {
        PrintData("Число не является палиндромом.");
    }
}
else
{
    PrintData("Число не пятизначное.");
}
// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0 ");
}
// Выводит результат
void PrintData(string msg1)
{
    Console.WriteLine(msg1);
}
// Проверка на палиндром
bool PalinTest(int n)
{
    bool res = false;
    int d1 = n / 10000;
    int d2 = (n / 1000) % 10;
    int d3 = (n % 100) / 10;
    int d4 = n % 10;
    res = (d1 == d4) && (d2 == d3) ? true : false;

    return res;
}

// Вариант 2 не придуман
// int num=00000;
// while(num<10000)
// {
//     if(PalinTest(num)==true)
//     {
//         var palin = new Dictionary<int, int>();
//         int index = 0;
//         palin[index] = num;
//         index++;
//         num++;
//     }
// }

