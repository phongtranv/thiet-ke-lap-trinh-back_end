using System;

namespace LAB2
{
    class Program
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Method to check if a number is prime
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Method to check and print prime numbers in an array
        public static void CheckPrimeNumbers(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(a[i]))
                {
                    Console.WriteLine($"Phần tử {a[i]} tại chỉ số {i} là số nguyên tố.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Declare variable n
            int n;
            // Input value for n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());

            // Declare and initialize integer array of size n
            int[] a = new int[n];

            // Call the function to input the array
            NhapMang(a, n);

            // Call the function to check for prime numbers and display them
            CheckPrimeNumbers(a, n);
        }
    }
}
