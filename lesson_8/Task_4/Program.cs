/*Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
Напишите программу, которая будет построчно выводить массив. 
Обратите внимание, что максимальный размер такого массива ограничен. 
Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

Количество возможных элементов - от 10 до 99 = 90, т.е  m * n <= 90
Пользователь задаёт m и n,  происходит проверка

в методе создания массива необходима проверка на повторяемость

*/

void FillRandomNotRepeat(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int rndNumber = rnd.Next(10, 100);

            while (MatrixCheck(matrix, rndNumber))
            {
                rndNumber = rnd.Next(10, 100);
            }

            matrix[i, j] = rndNumber;

        }
    }

}

bool MatrixCheck(int[,] matrix, int rndNumber)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == rndNumber)
                return true;
        }
    }

    return false;
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

Console.WriteLine("Введите количество строк таблицы");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов таблицы");
int columnCount = Convert.ToInt32(Console.ReadLine());
if (rowCount * columnCount <= 90)
{
    int[,] table = new int[rowCount, columnCount];
    FillRandomNotRepeat(table);
    PrintMatrix(table);
}
else Console.WriteLine("Недостежимый массив, введите меньшие значения количества строк или столбцов");

