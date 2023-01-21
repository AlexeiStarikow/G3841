// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// Вариант 1

// char [] digits = Console.ReadLine().ToCharArray();
// if(digits.Length>2)
// {
//     Console.WriteLine(digits[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Вариант 2
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()??"0");
// Создаем цикл, если в числе минимум три цифры
if(number > 99)
{
// Находим колличество цифр в числе
    int length = (int)Math.Log10(number) + 1;
    int index = 0;
    int thirdDigit = number;
// Делаем деление числа на 10 (length - 3) раз, чтобы осталось три цифры в числе
    while(index < length-3)
    {
        thirdDigit = thirdDigit/10;
        index++;
    }
// Находим третью цифру остатком от деления на 10
    thirdDigit = thirdDigit % 10;
// Выводим третье число
    Console.WriteLine(thirdDigit + " является третьей цифрой числа " + number);
}
else
{
// Выводим, если в числе меньше трех цифр
    Console.WriteLine("Число меньше 99, третьей цифры нет");
}