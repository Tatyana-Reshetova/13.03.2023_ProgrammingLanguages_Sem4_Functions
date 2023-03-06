// Напиите программу которая принимает на вход число N
// и выдает произведение числел от 1 до N

int Multiplication(int n)
{
    int Mult = 1;
    for (int i = 1; i <= n ; i++)
    Mult *= i;
    return Mult;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {n} равно {Multiplication(n)}");

