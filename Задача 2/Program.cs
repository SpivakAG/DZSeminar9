//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Задайте значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = Convert.ToInt32(Console.ReadLine());

int SumOfNaturalElements(int a, int b)
{
    if (a >= b+1) return 0;
    else return a + SumOfNaturalElements(a + 1, b);
}
Console.WriteLine(SumOfNaturalElements(m,n));