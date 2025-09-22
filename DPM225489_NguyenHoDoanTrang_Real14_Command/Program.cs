using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Command (Lệnh)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Tạo người dùng và cho phép cô ấy thực hiện tính toán
            User user = new User();
        // Người dùng nhấn các phím trên máy tính
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
        // Hoàn tác 4 lệnh
            user.Undo(4);
        // Làm lại 3 lệnh
            user.Redo(3);
        // Chờ người dùng
            Console.ReadKey();
        }
    }
