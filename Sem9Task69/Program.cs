//#69 
// Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печатает результат
void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}


long RecPowFlow(int a,int b)
{
    if(b<=1)return a;
    return a*RecPowFlow(a,b-1);
}

long MyPow(int a, int b)
{
    if(b==2)return a*a;
    return MyPow(a,b/2)*MyPow(a,b/2);
}

int a= ReadData("Введите число a: ");
int b= ReadData("Введите число b: ");


long res1=RecPowFlow(a,b);
PrintResult(res1);

long res2=MyPow(a,b);

PrintResult(res2);