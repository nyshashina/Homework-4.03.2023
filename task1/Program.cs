// Показать натуральные числа от 1 до N, N задано
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

/*void ShowNums(int n)
{
    for(int i = 1; i <= n; i++)
    {
        Console.Write($"{i} ");
    }
}*/
Console.WriteLine("Введите число");
int numberN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Натуральные числа от 1 до {numberN}: ");
int n = 1;
ShowNums(n,numberN);