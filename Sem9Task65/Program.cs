// Задача 65: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// натуральные элементы в промежутке от M до N.

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

string RecLineMN(int m, int n)
{
    if(m>=n)
    {
        return n.ToString();
    }
    else
    {
        return m + " " + RecLineMN(m+1,n);
    }
}

int numM= ReadData("Введите число М: ");
int numN= ReadData("Введите число N: ");

string res=numM<numN? RecLineMN(numM,numN):RecLineMN(numN,numM);
PrintResult(res);