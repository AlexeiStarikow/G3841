// Задача №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.
int positivSum = 0;
int negotivSum = 0;

int [] testArr=Gen1DArr(12,-9,9);
NegPosSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел в массиве: ", positivSum);
PrintData("Сумма отрицательных чисел в массиве: ", negotivSum);

// Метод выводит массив
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
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

void NegPosSum(int [] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i]>0)
        {
            positivSum+=arr[i];
        }
        else
        {
            negotivSum+=arr[i];
        }
    }
}