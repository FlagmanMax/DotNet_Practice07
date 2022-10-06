// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами (0,0);
// (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void FillArray(int[,] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = random.Next(-10,11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int getSumMainDiag(int[,] arr)
{
    int sum = 0;
    for (int i=0;i<arr.GetLength(0);i++)
    {
        sum += arr[i,i];
    }
    return sum;
}


Random random = new Random();
int m = random.Next(4,11);

Console.WriteLine($"Двумерный массив [{m},{m}]:");
int[,] array = new int[m,m];
FillArray(array);
PrintArray(array);

int sum = getSumMainDiag(array);
Console.WriteLine($"Сумма элементов на главной диагонали массива = {sum}");