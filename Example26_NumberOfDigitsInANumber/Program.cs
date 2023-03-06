// Напишите программу которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
//78 -> 2
//89126 -> 5

int CountNumbers(int n)
{
    int count = 0;
    if (n<0)
    n *= (-1); //n = n * (-1)
    while (n>0)
    {
        n/=10; //n = n/10 
        count++;
    }
    return count;  
}

Console.Clear();
Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
Console.Write ($"В числе {n} количество цифр - {CountNumbers(n)}.");


