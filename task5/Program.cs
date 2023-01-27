Console.Write("Введите число N: ");
var n = int.Parse(Console.ReadLine() ?? "");
var prod = 1;
if (n == 0)
    prod = 0;
else
    for (int i = 1; i <= n; i++)
        prod *= i;
Console.WriteLine($"Произведение всех чисел до числа {n} равна: {prod}");   