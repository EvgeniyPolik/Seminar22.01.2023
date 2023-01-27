int[] binaryArray = new int[8];
var rnd = new Random();
for (int i = 0; i < 8; i++)
    binaryArray[i] = rnd.Next(2);
Console.Write("Сформированный массив: ");
var sep = " ";
foreach (var element in binaryArray)
{
    Console.Write(element);
    Console.Write(sep);
}
