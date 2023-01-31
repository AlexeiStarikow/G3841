// Задача №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

// Метод выводит результат
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);

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
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return (n > 10 && n < 99);
}

int[] testArr = Gen1DArr(123, 0, 1000);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество элементов в отрезке[10,99] :", count);