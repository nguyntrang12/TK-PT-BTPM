using System;

/// <summary>
/// Mẫu thiết kế Chain of Responsibility (Chuỗi trách nhiệm)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Thiết lập chuỗi trách nhiệm
        Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);
        // Tạo và xử lý các yêu cầu
        int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }
        // Chờ người dùng nhấn phím
        Console.ReadKey();
        }
    }
