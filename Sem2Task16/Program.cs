// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Вариант 1

// int num1 = int.Parse(Console.ReadLine()??"0");
// int num2 = int.Parse(Console.ReadLine()??"0");

// int res1=num1*num1;
// int res2=num2*num2;

// if(num1 == res2 || num2 == res1)
// {
//     Console.WriteLine("Является квадратом");
// }
// else
// {   
//     Console.WriteLine("Не является квадратом");
// }

// Вариант 2

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

void TestSQRT(int i, int j)
{
    if(i*i == j)
    {
        Console.WriteLine("Число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("Число " + j + " не является квадратом числа " + i);
    }
}

TestSQRT(num1, num2);
TestSQRT(num2, num1);