// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int num = int.Parse(Console.ReadLine()??"0");
if(num>99 && num<1000)
{
    int res1=num/10;
    int res2=res1%10;
    Console.WriteLine(res2);
}
else
{
    Console.WriteLine("Число не трехзначное");
}