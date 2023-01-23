Console.Write("Введите число A: ");
var a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число B: ");
var b = int.Parse(Console.ReadLine() ?? "");
var result = 1;
for (int i = 0; i < b; i++)
    result *= a;
Console.WriteLine($"Число {a} в степени {b} равняется: {result}");
