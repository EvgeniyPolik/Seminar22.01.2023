Console.Write("Укажите длину массива: ");
var n = int.Parse(Console.ReadLine() ?? "");
int[] expArray = new int[n];
var rnd = new Random();
for (int i = 0; i < n; i++)
    expArray[i] = rnd.Next(1000);
Console.Write("Сформированный массив: ");
var sep = " ";
foreach (var element in expArray)
{
    Console.Write(element);
    Console.Write(sep);
}
Console.WriteLine();
for (int i = 0; i < n/2; i++)
    Console.WriteLine($"Сумма чисел пары {expArray[i]} и {expArray[n - 1 - i]} равна: {expArray[i] + expArray[n - 1 - i]}");
if (n % 2 != 0)
    Console.WriteLine($"Число без пары: {expArray[n/2]}");
