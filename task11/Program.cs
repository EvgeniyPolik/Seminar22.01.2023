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
var sumNotEventIndex = 0;
for (int i = 0; i < n; i++)
    if (i % 2 != 0)
        sumNotEventIndex += expArray[i];
Console.WriteLine($"Сумма чисел на нечетных позициях: {sumNotEventIndex}");