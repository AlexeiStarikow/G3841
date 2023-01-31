// Задача №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// Метод инвертирует массив
void InvArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}
// Метод создает новый инвертирует массив
int[] InvArrNew(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i] *= -1;
    }
    return newArr;
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
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
InvArr(testArr);
Print1DArr(testArr);
int[] testArrNew = InvArrNew(testArr);
Print1DArr(testArrNew);