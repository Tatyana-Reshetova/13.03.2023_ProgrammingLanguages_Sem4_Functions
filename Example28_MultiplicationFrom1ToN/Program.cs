// Напиите программу которая принимает на вход число N
// и выдает произведение числел от 1 до N

int GetMultiply(int n)
{
    int result = 1;
    int i = 2;
    if (n<0)
    {
        i=n;
        n=-1;
    }
    for (; i <= n ; i++)
    result *= i;
    return result;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел равно {GetMultiply(n)}");

