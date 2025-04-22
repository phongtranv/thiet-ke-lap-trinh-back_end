Console.Write("Nhập một số: ");
int number = int.Parse(Console.ReadLine());
bool isPrime = true;

for (int i = 2; i <= Math.Sqrt(number); i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}

if (isPrime && number > 1)
    Console.WriteLine("Số này là số nguyên tố.");
else
    Console.WriteLine("Số này không phải là số nguyên tố.");
