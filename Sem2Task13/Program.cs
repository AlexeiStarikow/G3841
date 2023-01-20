// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// Вариант 1

char [] digits = Console.ReadLine().ToCharArray();
if(digits.Length>2)
{
    Console.WriteLine(digits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


 