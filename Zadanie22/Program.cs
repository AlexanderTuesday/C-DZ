Console.Write("введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[linesVol, columnsVol];
ArrayRandomNumbers(num);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArray(num);

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < num.GetLength(1) - 1; k++)
        {
            if (num[i, k] < num[i, k + 1]) 
            {
                int temp = 0;
                temp = num[i, k];
                num[i, k] = num[i, k + 1];
                num[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Измененный массив:");
PrintArray(num);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}