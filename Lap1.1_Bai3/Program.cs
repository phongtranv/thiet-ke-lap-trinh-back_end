Console.Write("Nhập nhiệt độ (C): ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"Nhiệt độ tương đương là: {fahrenheit}°F");
