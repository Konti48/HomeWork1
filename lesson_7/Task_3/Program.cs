/*Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами 
(если палиндромов нет, то среднее арифметическое считать равным 0). 
Полученные средние арифметические занести в одномерный массив.

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

int rowCount = 15, columnCount = 10;
int[,] array = new int[rowCount, columnCount];
FillMatrix(array);
// PrintMatrix(array)
/*Как пробежаться по столбцам?
Подумать над применением цикла foreach для определения палиндрома
Найти сумму палиндромов и их количество
Найти среднее арифметическое
каждый столбец - это элемент одномерного массива
*/
