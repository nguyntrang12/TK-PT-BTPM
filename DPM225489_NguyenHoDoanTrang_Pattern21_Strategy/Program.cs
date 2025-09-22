using System;

/// <summary>
/// Mẫu thiết kế Strategy
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
            Context context;
        // Ba ngữ cảnh với các chiến lược khác nhau
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        // Chờ người dùng
            Console.ReadKey();
        }
    }
