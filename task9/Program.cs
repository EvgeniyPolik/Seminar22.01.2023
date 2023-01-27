Console.Write("Укажите длину массива: ");
var n = int.Parse(Console.ReadLine() ?? "");
int[] expArray = new int[n];
var rnd = new Random();
for (int i = 0; i < n; i++)
    expArray[i] = rnd.Next(100, 1000);
Console.Write("Сформированный массив: ");
var sep = " ";
foreach (var element in expArray)
{
    Console.Write(element);
    Console.Write(sep);
}
Console.WriteLine();
var evenCount = 0;
var notEvenCount = 0;
foreach (var element in expArray)
{
    if (element % 2 == 0)
        evenCount++;
    else
        notEvenCount++;
}
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}, нечетных {notEvenCount}");
