// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Метод выводит результат
void PrintData(string msg1)
{
    Console.WriteLine(msg1);

}
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
// Метод ищет в массиве заданный элемент
int Search(int[] arr, int e)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == e)
        {
            res = i;
            break;
        }
    }
    return res;
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
int element = ReadData("Какой элемент найти?: ");
int result = Search(testArr, element);

if (result >= 0)
{
    PrintData("Элемент найден в позиции: " + result);
}
else
{
    PrintData("Элемент в массиве не найден!");
}
