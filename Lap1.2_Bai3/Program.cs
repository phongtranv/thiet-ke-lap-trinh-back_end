using System;

namespace LAB2
{
    class Program
    {
        // Hàm nhập mảng
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Hàm đếm số dương và số âm trong mảng
        public static void CountPositiveNegative(int[] a, int n)
        {
            int positiveCount = 0, negativeCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0) positiveCount++;   // Đếm số dương
                else if (a[i] < 0) negativeCount++;  // Đếm số âm
            }
            Console.WriteLine($"Số dương: {positiveCount}, Số âm: {negativeCount}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến n
            int n;
            // Nhập giá trị cho n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());

            // Khai báo và khởi tạo mảng số nguyên có kích thước n
            int[] a = new int[n];

            // Gọi hàm nhập mảng
            NhapMang(a, n);

            // Gọi hàm đếm số dương và số âm
            CountPositiveNegative(a, n);
        }
    }
}
