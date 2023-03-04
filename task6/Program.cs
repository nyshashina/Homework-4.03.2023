// Написать программу возведения числа А в целую стень B
int ShowNums(int i, int number)
{
    if (number == 1)
    {
        return i;
    }
    number = number - 1;
    return i*ShowNums(i,number);
}
Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень");
int numberB = int.Parse(Console.ReadLine() ?? "0");

Console.Write($"Число {numberA}, возведенное в степень {numberB}, равно: ");
Console.Write(ShowNums(numberA,numberB));

