// Напишите программу которая принимает на вход число А
// и выдает сумму чисел от 1 до А
// а = 5
// sum = 1 + 2 + 3 + 4 + 5




Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
// int a = GetSum(n);
Console.WriteLine($"Сумма чисел от 1 до {n} равна {GetSum(n)}");

int GetSum (int n){
    int sum = 0;
    for (int i = 1; i <= n; i ++)
    sum += i;// sum = sum + i
    return sum;
}
