Console.Write("Nhập số nguyên dương: ");
int n = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= n; i++)
{
    result *= i;
}
Console.WriteLine($"Giai thừa của {n} là: {result}");
