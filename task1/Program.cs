Console.Write("Введите число N: ");
var n = int.Parse(Console.ReadLine() ?? "");
Console.Write($"Все кубы чисел до {n}: ");
for (int i = 1; i <= n; i++)
{
    Console.Write(Math.Pow(i, 3));
    Console.Write(" ");
}