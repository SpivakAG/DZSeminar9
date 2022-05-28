//  Задача 68:Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Задайте значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = Convert.ToInt32(Console.ReadLine());
int Akkerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0)
    {
        return Akkerman(a - 1, 1);
    }
    else
    {
        return Akkerman(a - 1, Akkerman(a, b - 1));
    }
}
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");