/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 Выполнить с помощью рекурсии.
*/
int m = 3;
int n = 5;
int GetSumUntilNums(int a, int b)
{
    if (b == a) return a;
    else return b + GetSumUntilNums(a, b - 1);
}

Console.WriteLine(GetSumUntilNums(m, n));
