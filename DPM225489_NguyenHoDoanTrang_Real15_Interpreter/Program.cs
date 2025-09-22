using System;
using System.Collections.Generic;
using System.Linq.Expressions;

    /// <summary>
    /// Mẫu thiết kế Interpreter (Giải thích)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);
        // Xây dựng 'cây phân tích'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());
        // Giải thích
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}",
                roman, context.Output);
        // Chờ người dùng
            Console.ReadKey();
        }
    }
