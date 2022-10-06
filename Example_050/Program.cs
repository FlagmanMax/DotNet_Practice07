// Задача 50: Напишите программу, которая на вход
// принимает индексы элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 3 -> 3


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

Console.WriteLine("Введите индексы элемента:");
Console.Write("m = ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n1 = Convert.ToInt32(Console.ReadLine());

if ((m1 >= m) || (n1 >= n))
{
    Console.WriteLine("Такого элемента нет в массиве");
}
else
{
    Console.WriteLine($"A[{m-1},{n-1}] = {array[m1,n1]}");
}





