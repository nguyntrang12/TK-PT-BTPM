using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Observer
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Cấu hình mẫu thiết kế Observer
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
        // Thay đổi trạng thái chủ thể và thông báo cho các Observer
            s.SubjectState = "ABC";
            s.Notify();
        // Chờ người dùng
            Console.ReadKey();
        }
    }