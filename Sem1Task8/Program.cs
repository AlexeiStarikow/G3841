// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

//Считываем данные с консоли
string? number = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(number!=null)
{
    // Парсим введенное число
    int Num = int.Parse(number);
    string result = string.Empty;
    for(int i = 2; i < Num; i = i + 2)
    {
        result = result + i + ",";
        
    }

    if(Num % 2 == 0)
    {
        result = result + Num;
    }
    Console.WriteLine(result);
}