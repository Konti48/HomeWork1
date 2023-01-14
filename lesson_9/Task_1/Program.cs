/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
*/
int num = 9;
int PrintRow(int n)
{
    Console.Write(n + " "); 

    if (n == 1) return 1;
    else return PrintRow(n - 1);
}
PrintRow(num);
