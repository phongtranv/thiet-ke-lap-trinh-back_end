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

        public static int TinhTongChan(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)  // Check if the number is even
                {
                    tong += a[i];
                }
            }
            return tong;
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

            // Call the function to calculate the sum of even numbers and display the result
            int sumEven = TinhTongChan(a, n);
            Console.WriteLine($"Tổng các số chẵn trong mảng là: {sumEven}");
        }
    }
}
