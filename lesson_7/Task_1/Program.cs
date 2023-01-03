Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] table = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        double ranDouble = Math.Round(rnd.NextDouble(), 2);
        int ranInteger = rnd.Next(0, 10);
        table[i, j] = ranInteger + ranDouble;
        Console.Write(table[i, j] + " ");
    }
    Console.WriteLine();
}
