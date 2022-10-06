// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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

void UpdateArray(int[,] arr)
{
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            if (((i+1)%2==0) && ((j+1)%2==0))
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
}

Random random = new Random();
int m = random.Next(2,11);
int n = random.Next(2,11);

Console.WriteLine($"Двумерный массив [{m},{n}]:");
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);

Console.WriteLine();

UpdateArray(array);
PrintArray(array);