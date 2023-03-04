// Показать натуральные числа от N до 1, N задано
void ShowNums(int i, int number)
{
    Console.Write($"{number - i} ");
    if (i >= number - 1)
    {
        return;
    }
    i++;
    ShowNums(i,number);
}
/*void ShowNums(int n)
{
    for(int i = 0; i <= n; i++)
    {
        Console.Write($"{n-i} ");
    }
}*/
Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Натуральные числа от {numberN} до 1: ");
int n = 0;
ShowNums(n,numberN);