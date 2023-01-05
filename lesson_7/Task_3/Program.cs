/*Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами 
(если палиндромов нет, то среднее арифметическое считать равным 0). 
Полученные средние арифметические занести в одномерный массив.

Как пробежаться по столбцам?
Найти палиндром
Найти сумму палиндромов и их количество
Найти среднее арифметическое
каждый столбец - это элемент одномерного массива
*/
void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(100, 1000);
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

int rowCount = 10, columnCount = 20;
int[,] array = new int[rowCount, columnCount];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
double[] newArray = new double[columnCount];
for (int j = 0; j < array.GetLength(1); j++)
{
    int total = 0;
    int count = 0;
    double meanValue = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, j] % 10 == array[i, j] / 100)
        {
            total += array[i, j];
            count++;
            meanValue = total / count;
        }
    }
    newArray[j] = meanValue;
    Console.Write(newArray[j] + " ");
}