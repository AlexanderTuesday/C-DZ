Console.Write("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
ArrayRandomNumbers(numbers);


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


PrintArray(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double middle = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        middle = (middle + numbers[i, j]);
    }
    middle = middle / n;
    Console.Write(middle + "/");
}
Console.WriteLine();
