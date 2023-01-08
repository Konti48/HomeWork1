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

void PrintNumberOfRowsWithMinSum(int[,] matrix)
{
    int minSum = 0;
    int rowSum = 0;
    int rowCount = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minSum += matrix[0, j];
            rowSum += matrix[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            rowCount = i++;
        }
    }
    Console.WriteLine(rowCount);
}

int rowCount = 3, columnCount = 3;
int[,] table = new int[rowCount, columnCount];
FillMatrix(table);
PrintMatrix(table);
PrintNumberOfRowsWithMinSum(table);
