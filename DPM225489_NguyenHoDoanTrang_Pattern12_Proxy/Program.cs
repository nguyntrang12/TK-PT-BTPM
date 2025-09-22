using System;

/// <summary>
/// Mẫu thiết kế Proxy (Đại diện)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Tạo proxy và gọi một dịch vụ
        Proxy proxy = new Proxy();
            proxy.Request();
        // Chờ người dùng nhấn phím
        Console.ReadKey();
        }
    }
