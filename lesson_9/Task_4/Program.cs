/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] FillSpiralMatrix(int n)
{
    int[,] matrix = new int[n, n];
    int start = 1, end = n * n;
    int i = 0, j = 0;
    while (start <= end)
    {
        matrix[i, j] = start;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
        start++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString("D2") +" ");
        }
        Console.WriteLine();
    }
}

int n = 4;
PrintMatrix(FillSpiralMatrix(n));