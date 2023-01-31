// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] ConvertArr(int[] arr)
{
    int[] resArr = new int[(arr.Length/2) + 1];
    for (int i = 0; i < resArr.Length; i++)
    {
        resArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return resArr;
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

int[] testArr = Gen1DArr(123, 0, 1000);
Print1DArr(testArr);
int[] convArr = ConvertArr(testArr);
Print1DArr(convArr);
Print1DArr(testArr);
