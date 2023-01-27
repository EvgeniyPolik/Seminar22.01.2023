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
Console.Write("Введите искомое число: ");
var findItem = int.Parse(Console.ReadLine() ?? "");
var findIndex = -1;
for (int j = 0; j < n; j++)
    if (expArray[j] == findItem)
    {
        findIndex = j;
        break;
    }
if (findIndex == -1)
    Console.WriteLine($"Число {findItem} в массиве не обнаружено");
else
    Console.WriteLine($"Число {findItem} обнаружено на позиции {findIndex + 1}");
