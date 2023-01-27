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
var maxElement = expArray[0];
var minElement = expArray[0];
foreach (var item in expArray)
{
    if (item > maxElement)
        maxElement = item;
    if (item < minElement)
        minElement = item;
}
Console.WriteLine($"Разница между максимальным({maxElement}) и минимальным({minElement}) элементом равна: {maxElement - minElement}");
