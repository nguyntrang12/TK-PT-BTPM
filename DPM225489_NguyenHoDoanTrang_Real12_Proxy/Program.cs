using System;

/// <summary>
/// Mẫu thiết kế Proxy (Đại diện)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Tạo proxy cho phép toán
        MathProxy proxy = new MathProxy();
        // Thực hiện phép toán
        Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
        // Chờ người dùng nhấn phím
        Console.ReadKey();
        }
    }
/// <summary>
/// Giao diện 'Subject' (Chủ thể)
/// </summary>
public interface IMath
{
    double Add(double x, double y);
    double Sub(double x, double y);
    double Mul(double x, double y);
    double Div(double x, double y);
}