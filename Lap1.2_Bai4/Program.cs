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

        // Hàm tìm số lớn thứ hai trong mảng
        public static int FindSecondLargest(int[] a, int n)
        {
            int largest = int.MinValue, secondLargest = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > largest)
                {
                    secondLargest = largest;
                    largest = a[i];
                }
                else if (a[i] > secondLargest && a[i] != largest)
                {
                    secondLargest = a[i];
                }
            }
            return secondLargest;
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

            // Gọi hàm tìm số lớn thứ hai và hiển thị kết quả
            int secondLargest = FindSecondLargest(a, n);
            Console.WriteLine($"Số lớn thứ hai trong mảng là: {secondLargest}");
        }
    }
}
