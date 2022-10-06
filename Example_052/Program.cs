// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 6; 3

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

void AverageValueForEachColumn(int[,] arr)
{
    int rows = arr.GetLength(0);
    double ave = 0;

    for (int j=0;j<arr.GetLength(1);j++)
    {
        ave = 0;
        for (int i=0;i<rows;i++)
        {
            ave += arr[i,j];
        }
        Console.WriteLine("Среднее значение " + j + " столбца = {0:0.00}",ave/rows);
    }
}


Random random = new Random();
int m = random.Next(3,9);
int n = random.Next(3,9);
Console.WriteLine($"Двумерный массив А[{m},{n}]");

int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
AverageValueForEachColumn(array);
