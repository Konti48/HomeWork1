void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 100);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write(matrix[i, j] + " ");
        }
            Console.WriteLine();
    }
}

int rowCount = 6, columnCount = 9;
int[,] array = new int[rowCount, columnCount];
FillMatrix(array);
PrintMatrix(array);

Console.WriteLine("Введите индекс строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int n = Convert.ToInt32(Console.ReadLine());
if (m < array.GetLength(0) && n < array.GetLength(1)) Console.WriteLine(array[m, n]);
else Console.WriteLine("Введённые индексы находятся за пределом таблицы");