// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Выводим результат
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int sumSimple(int numA)
{
    int sumOfNum = 1;
    for (int i = 2; i <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}

int sumGauss(int numA)
{
    return (numA * (numA + 1)) / 2;
}
int numberA = ReadData("Введите число А");
DateTime d1 = DateTime.Now;
int res1 = sumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = sumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);
PrintData("Сумма чисел от 1 до А(sumSimple): ", res1);
PrintData("Сумма чисел от 1 до А(sumGauss): ", res2);