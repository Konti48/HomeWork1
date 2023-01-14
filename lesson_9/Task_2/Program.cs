/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 Выполнить с помощью рекурсии.
*/
int m = 8, n = 18;
int GetSumUntilNums(int a, int b)
{
    if (b == a) return a;
    else return b + GetSumUntilNums(b - 1);
}

Console.WriteLine(GetSumUntilNums(m, n));
