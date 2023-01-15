/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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

int GetNumberOfRowsWithMinSum(int[,] matrix)
{
    int minSum = 0;
    int rowCount = 1;
    for (int k = 0; k < matrix.GetLength(1); k++) // присваиваем минимальное значение сумме элементов первой строки
    {
        minSum += matrix[0, k];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            rowCount = i + 1;
        }
    }
    return rowCount;
}

int rowCount = 5, columnCount = 5;
int[,] table = new int[rowCount, columnCount];
FillMatrix(table);
PrintMatrix(table);
GetNumberOfRowsWithMinSum(table);
Console.WriteLine($"{GetNumberOfRowsWithMinSum(table)}-я строка с наименьшей суммой элементов");