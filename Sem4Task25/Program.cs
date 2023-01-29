// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод определения операции
string ReadOper(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Выводим результат
void PrintData(int msg)
{
    Console.WriteLine(msg);
}

// Метод сложения
int Adding(int a, int b)
{
    int res = a + b;
    return res;
}

// Метод вычитания
int Subtr(int a, int b)
{
    int res = a - b;
    return res;
}

// Метод деления
int Div(int a, int b)
{
    int res = a / b;
    return res;
}

// Метод умножения

int Multip(int a, int b)
{
    int res = a * b;
    return res;
}

// Метод возведения в степень
int Pow(int a, int b)
{
    int res = 1;
    while (b > 0)
    {
        b = b - 1;
        res = res * a;
    }
    return res;
}
// Вводим числа
int num1 = ReadData("Введите первое число: ");
int num2 = ReadData("Введите второе число: ");
// Вводим операцию
string oper = ReadOper("Выберите операцию(+,-,/,*,**)");
// если +
if (oper == "+")
{
    int num3 = Adding(num1, num2);
    PrintData(num3);

}
// если -
else if (oper == "-")
{
    int num3 = Subtr(num1, num2);
    PrintData(num3);
}
// если /
else if (oper == "/")
{
    int num3=Div(num1,num2);
    PrintData(num3);
}
// если *
else if(oper == "*")
{
    int num3=Multip(num1,num2);
    PrintData(num3);
}
// если **
else if(oper == "**")
{
    int num3=Pow(num1,num2);
    PrintData(num3);
}
else
{
    Console.WriteLine("Такой операции в нашем калькуляторе нет)");
}