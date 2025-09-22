using System;

/// <summary>
/// Mẫu thiết kế Template
/// </summary>

public class Program
    {
        public static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            // Chờ người dùng
            Console.ReadKey();
        }
    }
