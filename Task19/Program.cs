Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
int lastDigit = number%10;
int firstDigit = number/10000;
int secondDigit = number/1000%10;
int penultimateDigit = number/10%10;
if (number > 99999 || number < 10000)
{
    Console.WriteLine("Введите пятизначное число");
}
else
{
if (lastDigit == firstDigit || secondDigit == penultimateDigit)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
}