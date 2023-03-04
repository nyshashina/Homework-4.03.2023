// Показать натуральные числа от M до N, N и M заданы
void ShowNums(int i, int number)
{
    Console.Write($"{i} ");
    if (i >= number)
    {
        return;
    }
    i++;
    ShowNums(i,number);
}
Console.WriteLine("Введите первое число");
int numberM = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int numberN = int.Parse(Console.ReadLine() ?? "0");
if(numberM <= numberN && numberM > 0 && numberN > 0)
{
    Console.WriteLine($"Натуральные числа от {numberM} до {numberN}: ");
    ShowNums(numberM,numberN);
}
else
{
    Console.WriteLine("Числа должны быть натуральными. Первое число должно быть меньше второго.");
}
