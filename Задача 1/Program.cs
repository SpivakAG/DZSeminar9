// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.WriteLine("Задайте значение N:");
int n = Convert.ToInt32(Console.ReadLine());

string AllNaturalNumbers(int a)
{
    if (a > 2) return $"{a}, " + AllNaturalNumbers(a - 1);
    else if (a == 2) return $"{a}, {a - 1}"; //только для того чтобы последнее число выводилось без запятой
    else return String.Empty;
}
Console.WriteLine(AllNaturalNumbers(n));