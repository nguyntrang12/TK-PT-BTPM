using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Template
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            // Chờ người dùng
            Console.ReadKey();
        }
    }