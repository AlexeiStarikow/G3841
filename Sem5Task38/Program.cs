// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Метод вывода
void PrintData(string msg1, double msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);

}

// Метод генерирует массив вещественных чисел
double[] Gen1DArr(int num, int begin, int end)
{
    double[] arr = new double[num];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * 10;
    }
    return arr;
}
// Метод выводит массив
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод выводит массив целых
void Print1DArrInt(int[] arr)
{
    Console.Write("[");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод находит разницу между максимальным и минимальным элементами
double Dif(double[] arr)
{
    double res = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] < min)
        {
            min = arr[j];
        }
    }
    res = max - min;
    return res;
}


double[] testArr = Gen1DArr(10, 1, 10);
Print1DArr(testArr);
double diff = Dif(testArr);
PrintData("Разница между максимальным и минимальным элементами равна: ", diff);

// Метод генерирует массив чисел
int[] Gen1DArrInt(int num, int begin, int end)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}
// Создаем,сортируем и выводим массив
int[] testArrInt = Gen1DArrInt(10, 1, 10);
Print1DArrInt(testArrInt);
int[] testArInSort = Search(testArrInt);
Print1DArrInt(testArInSort);

// Метод сортирует вставками
int[] Search(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int k = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            arr[j] = k;
            j--;

        }
    }
    return arr;
}

