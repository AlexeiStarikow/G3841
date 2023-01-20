// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным. 

// Вариант 1

// int day = int.Parse(Console.ReadLine()??"0");
// if(day>7 || day<1)
// {
//     Console.WriteLine("Это не день недели");
// }
// else
// {
//     if(day>5)
//     {
//         Console.WriteLine("Выходной");
//     }
//     else
//     {
//         Console.WriteLine("Рабочий");
//     }
// }

// Вариант 2

int day = int.Parse(Console.ReadLine()??"0");

var days = new Dictionary<int, string>()
{
    [1] = "Рабочий",
    [2] = "Рабочий",
    [3] = "Рабочий",
    [4] = "Рабочий",
    [5] = "Рабочий",
    [6] = "Выходной",
    [7] = "Выходной"
};

if(day<8 && day>0)
{
    Console.WriteLine(days[day]);
}
else
{
    Console.WriteLine("Это не день недели");
}