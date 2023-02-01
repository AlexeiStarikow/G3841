// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
// Метод считает сумму элементов на нечетных позициях
int SumPos(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        if (arr[i] % 2! == 0)
        {
            sum += arr[i];
        }

    }
    return sum;
}
// Метод ищет пары в массиве
void Search(int[] arr)
{
    int res1 = 0;
    int res2 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                res1 = arr[i];
                res2 = arr[j];
                Console.WriteLine($"{res1}, {res2}, {i}, {j}");
                i++;
                j++;
            }
            else
            {
                break;
            }

        }
    }
}

int[] testArr = Gen1DArr(10, 1, 7);
Print1DArr(testArr);
int result = SumPos(testArr);
PrintData("Сумма всех элементов нечетных позиций равна: ", result);
Search(testArr);