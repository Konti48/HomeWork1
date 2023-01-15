/*Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
произведение квадратной матрицы = матрица того же размера, заполненная суммой произведений элементов по строкам и столбцам
т.е. новая матрица 
    0.0 = 00*00 + 01*10 + 02*20... 
    0.1 = 00*01 + 01*11 + 02*21...   
    0.2 = 00*02 + 01*12 + 02*22...

    1.0 = 10*00 + 11*10 + 12*20... 
    1.1 = 10*01 + 11*11 + 12*21...   
    1.2 = 10*02 + 11*12 + 12*22...

    2.0 = 20*00 + 21*10 + 22*20... 
    2.1 = 20*01 + 21*11 + 22*21...   
    2.2 = 20*02 + 21*12 + 22*22...
       
первую матрицу перебираем по строкам, вторую - по столбцам, умножаем на каждой итерации и кладём в сумму
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(0); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newMatrix;
}

int sizeTable = 3;
int[,] table1 = new int[sizeTable, sizeTable];
int[,] table2 = new int[sizeTable, sizeTable];

FillMatrix(table1);
PrintMatrix(table1);
Console.WriteLine(string.Empty);
FillMatrix(table2);
PrintMatrix(table2);
Console.WriteLine(string.Empty);
int[,] resultMatrix = MultiplyMatrix(table1, table2);
PrintMatrix(resultMatrix);


