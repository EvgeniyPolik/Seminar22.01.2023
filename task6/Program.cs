Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine() ?? "");
for (int i = 0; i <= n; i++)
{
    int num = (int)Math.Pow(i, 3);
    if (num % 2 == 0)
        Console.WriteLine(num); 
}

/* ver2
IEnumerable<int> GenerateSequence() 
{
    var i = 0;
    while (true)
    {
        int num = (int)Math.Pow(i, 3);
        if (num % 2 == 0)
            yield return num; 
        i++;      
    }
}

foreach (var item in GenerateSequence())
{
    Console.WriteLine(item);
    Thread.Sleep(500);
    if (Console.KeyAvailable) break;
}
*/