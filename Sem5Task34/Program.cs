// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример
// [345, 897, 568, 234] -> 2

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
// Метод ищет количество четных чисел в массиве
int Test(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}
// Сортировка методом пузырька
int[] SortBub(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                temp = arr[j];
            }

        }
    }
    return arr;
}


int[] testArr = Gen1DArr(10, 99, 1000);
Print1DArr(testArr);
int result = Test(testArr);
PrintData("Количество четных чисел в массиве: ", result);

// Метод пузырька
int [] bubble=SortBub(testArr);
Print1DArr(bubble);

