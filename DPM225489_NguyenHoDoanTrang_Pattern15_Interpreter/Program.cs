using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Interpreter (Giải thích)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();
        // Thường là một cây  
            List<AbstractExpression> list = new List<AbstractExpression>();
        // Tạo 'cây cú pháp trừu tượng' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
        // Giải thích
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        // Chờ người dùng
            Console.ReadKey();
        }
    }