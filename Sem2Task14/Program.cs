// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int num = int.Parse(Console.ReadLine()??"0");
int res1 = num%7;
int res2 = num%23;
if(res1 == 0 && res2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}