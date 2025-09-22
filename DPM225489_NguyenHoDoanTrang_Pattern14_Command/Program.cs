using System;

/// <summary>
/// Mẫu thiết kế Command (Lệnh)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Tạo receiver, command (lệnh), và invoker (người gọi)
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
        // Thiết lập và thực thi lệnh
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        // Chờ người dùng nhấn phím
            Console.ReadKey();
        }
    }

