// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

void FillArray(int[,] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = random.Next(-100,101);
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

Random random = new Random();
int m = random.Next(1,11);
int n = random.Next(1,11);

Console.WriteLine($"Двумерный массив [{m},{n}]:");
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);