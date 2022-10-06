// Дан двумерный массив из двух строк и двадцати двух столбцов. В его пер-
// вой строке записано количество мячей, забитых футбольной командой в той 
// или иной игре, во второй — количество пропущенных мячей в этой же игре. 
// а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выиг-
// рыш", "ничья" или "проигрыш".
// выигрышей данной команды. 
// в) Определить  количество  выигрышей  и  количество  проигрышей  данной  
// команды. 
// г) Определить количество выигрышей, количество ничьих и количество про-
// игрышей данной команды. 
// д) Определить,  в  скольких  играх  разность  забитых  и  пропущенных  мячей 
// была большей или равной трем. 
// е) Определить общее число очков, набранных командой (за выигрыш даются 
// 3 очка, за ничью — 1, за проигрыш — 0).

void FillArray(int[,] arr, int min=0, int max = 11)
{
    Random random = new Random();
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = random.Next(min,max);
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

void Answer1(int[,] array)
{
    for (int i=0;i<array.GetLength(1);i++)
    {
        if (array[0,i]>array[1,i])
        {
            Console.WriteLine($"Игра {i+1}: выигрыш");
        }
        else if (array[0,i] == array[1,i])
        {
            Console.WriteLine($"Игра {i+1}: ничья");
        }
        else
        {
            Console.WriteLine($"Игра {i+1}: проигрыш");
        }
    }
}

void Answer2(int[,] array)
{
    int win = 0;
    int loose = 0;
    for (int i=0;i<array.GetLength(1);i++)
    {
        if (array[0,i]>array[1,i])
        {
            win++;
        }
        else if (array[0,i] == array[1,i])
        {

        }
        else
        {
            loose++;
        }
    }
    Console.WriteLine($"Выигрышей {win}");
    Console.WriteLine($"Проигрышей {loose}");
    Console.WriteLine($"Ничьих {array.GetLength(1)-win-loose}");
}

void Answer3_diff3(int[,] array)
{
    int count = 0;
    for (int i=0;i<array.GetLength(1);i++)
    {
        if (Math.Abs(array[0,i]-array[1,i])>=3)
        {
            count++;
        }
    }
    Console.WriteLine($"В {count} играх  разность  забитых  и  пропущенных  мячей была большей или равной трем");
}

void getPoints(int[,] array)
{
    int points = 0;

    for (int i=0;i<array.GetLength(1);i++)
    {
        if (array[0,i]>array[1,i])
        {
            points += 3;
        }
        else if (array[0,i] == array[1,i])
        {
            points += 1;
        }
    }
    Console.WriteLine($"Общее число очков, набранных командой = {points}");
}


int m = 2;
int n = 20;

int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);

Answer1(array);
Answer2(array);
Answer3_diff3(array);
getPoints(array);




