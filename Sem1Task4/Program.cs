// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.

//Считываем данные с консоли
string? number1 = Console.ReadLine();
string? number2 = Console.ReadLine();
string? number3 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(number1!=null && number2!=null && number3!=null)
{
    // Парсим введенные числа
    int Num1 = int.Parse(number1);
    int Num2 = int.Parse(number2);
    int Num3 = int.Parse(number3);
    // Сравниваем числа
    if(Num1>Num2)
    {
        if(Num1>Num3)
        Console.WriteLine(Num1);
        else
        Console.WriteLine(Num3);
    }
    else
    {
        if(Num2>Num3)
        {
            Console.WriteLine(Num2);
        }
        else
        {
            Console.WriteLine(Num3);
        }
    }
}