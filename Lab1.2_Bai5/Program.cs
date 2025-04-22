using System;

namespace LAB2
{
    class Program
    {
        // Hàm hoán đổi giá trị của hai biến
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo hai biến
            int x, y;

            // Nhập giá trị cho hai biến
            Console.Write("Nhập giá trị x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị y: ");
            y = int.Parse(Console.ReadLine());

            // Hiển thị giá trị trước khi hoán đổi
            Console.WriteLine($"Trước khi hoán đổi: x = {x}, y = {y}");

            // Gọi hàm hoán đổi
            Swap(ref x, ref y);

            // Hiển thị giá trị sau khi hoán đổi
            Console.WriteLine($"Sau khi hoán đổi: x = {x}, y = {y}");
        }
    }
}
