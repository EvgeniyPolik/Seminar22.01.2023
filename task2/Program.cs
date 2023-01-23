Console.Write("Введите число A: ");
var a = int.Parse(Console.ReadLine() ?? "");
var sum = 0;
for (int i = 1; i <= a; i++)
    sum += i;
Console.WriteLine($"Сумма всех чисел до числа {a} равна: {sum}");   

