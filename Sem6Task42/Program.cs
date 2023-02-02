// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);

}
// Метод переводит в десятичное
string Convert10to2(int num)
{
    string result = "";
    while (num >= 1)
    {
        result = result + Convert.ToString(num % 2);
        num = num / 2;
    };
    return result;

}

int numTest = ReadData("Введите число");
PrintData("Число в двоичной системе: ", Convert10to2(numTest));