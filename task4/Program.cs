Console.Write("Введите число N: ");
var n = int.Parse(Console.ReadLine() ?? "");
var count = 0;
var tmp = n;
if (n == 0)
    count++;
else
    while (tmp != 0)
    {
        count++;
        tmp /= 10;
    }
Console.WriteLine($"В числе {n} количество знаков: {count}");