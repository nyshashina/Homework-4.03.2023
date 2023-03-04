// Показать натуральные числа от 1 до N, N задано
/*int CountNums(int n)
{
    if (n > 1) return CountNums(n)+1;
    else return 1;
}
Console.WriteLine(CountNums(10));*/
void ShowNums(int n)
{
    for(int i = 1; i <= n; i++)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Натуральные числа от 1 до {numberN}: ");
ShowNums(numberN);