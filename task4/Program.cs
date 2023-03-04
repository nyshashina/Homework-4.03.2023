// Найти сумму цифр в числе
void SumNums(int i, int n)
{
    i = i + n % 10;
    n = n / 10;
    if (n == 0)
    {
        Console.Write(i);
        return;
    }
    SumNums(i,n);
}
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");

/*int sum = 0;
int numberB = numberA;
while (numberB > 0)
{
    sum = sum + numberB % 10;
    numberB = numberB / 10;
}*/
int sum = 0;
int temp = numberA;

Console.WriteLine("Сумма цифр в числе " + numberA + " равна ");
SumNums(sum, temp);
