// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами,
// округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void FillArray(double[,] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = random.Next(-100,101)/10.0;
        }
    }
}

void PrintArray(double[,] arr)
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
int m = random.Next(3,11);
int n = random.Next(3,11);

Console.WriteLine($"Двумерный массив [{m},{n}]:");
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);
