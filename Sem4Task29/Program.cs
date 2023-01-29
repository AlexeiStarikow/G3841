// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод генерирует массив
int[] Gen1DArr(int num, int begin, int end)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}
// Метод выводит массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива");
int low = ReadData("Введите нижнюю границу");
int up = ReadData("Введите верхнюю границу");
int[] arr = Gen1DArr(arrLen, low, up);
Print1DArr(arr);
// * Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал 
Console.Write("Введите имена: ");
string names = (Console.ReadLine()?? "0");
// создаем массив имен
string[] words = names.Split(new char[] { ',' });
// Выводим рандомное имя
Console.WriteLine(words[new Random().Next(0, words.Length)]);
