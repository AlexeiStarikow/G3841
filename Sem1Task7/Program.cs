// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.


//Считываем данные с консоли
string? inputNum = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(inputNum!=null)
{
// Парсим введенное число
    int inputNum1 = int.Parse(inputNum);

int lastDigit = inputNum1%10;

Console.WriteLine(lastDigit);
}