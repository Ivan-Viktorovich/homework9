// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Sum (int n, int m)
{
    if (n == m)
    {
        return n;
    }
    return m + Sum(n,m - 1);
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum = Sum(n,m);
Console.WriteLine(sum);