var rnd = new Random();
int[] expArray = new int[123];
for (int i = 0; i < 123; i++)
    expArray[i] = rnd.Next(1000);
var countFind = 0;
Console.Write("Сформированный массив: ");
var sep = " ";
foreach (var item in expArray)
{
    Console.Write(item);
    Console.Write(sep);
}
Console.WriteLine();
foreach (var item in expArray)
    if (item >= 10 && item <= 99)
        countFind++;
Console.WriteLine($"Количество вхождений из отрезка [10, 99] составляет: {countFind}");