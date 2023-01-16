// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

//Считываем данные с консоли
string? number1 = Console.ReadLine();
string? number2 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(number1!=null && number2!=null)
{
    // Парсим введенные числа
    int Num1 = int.Parse(number1);
    int Num2 = int.Parse(number2);
    // Сравниваем числа
    if(Num1>Num2)
    {
        Console.Write("Наибольшее число - ");
        Console.Write(Num1);
    }
    else
    {
        Console.Write("Наибольшее число - ");
        Console.Write(Num2);
    }
        
}