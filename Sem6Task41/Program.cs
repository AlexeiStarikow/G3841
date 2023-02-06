// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Метод считывает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
string ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

// Метод проверки массива на кол-во чисел >0
void CheckNum(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (int.Parse(arr[i]) > 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

int qNums = ReadData("Введите количество чисел: ");
string nums = ReadDataStr("Введите числа через запятую");
string[] digts = nums.Split(new char[] { ',' });
CheckNum(digts);




