/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
создать массив
вывести на экран
массив построчно по убыванию (Преобразовать метод для одномерного массива из лекции 3) 
вывести на экран новый массив
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
void SelectionSortMaxMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, maxPosition];
            matrix[i, maxPosition] = temporary;
        }

    }
}

int rowCount = 5, columnCount = 8;
int[,] array = new int[rowCount, columnCount];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine(String.Empty);
SelectionSortMaxMin(array);
PrintMatrix(array);
