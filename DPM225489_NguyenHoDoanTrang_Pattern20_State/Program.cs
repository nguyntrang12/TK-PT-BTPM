using System;

/// <summary>
/// Mẫu thiết kế State
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Thiết lập ngữ cảnh trong một trạng thái
            var context = new Context(new ConcreteStateA());
        // Thực hiện các yêu cầu, thay đổi trạng thái
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        // Chờ người dùng
            Console.ReadKey();
        }
    }