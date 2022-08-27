Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int i = 1;
Console.Write(n + "-> ");
n = Math.Abs(n);
while (i <= n)
{
    Console.Write(Math.Pow(i, 3) + ",");
    i++;
}
