using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Iterator (Lặp qua tập hợp)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
        // Tạo Iterator và cung cấp tập hợp
            Iterator i = a.CreateIterator();
            Console.WriteLine("Iterating over collection:");
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        // Chờ người dùng
            Console.ReadKey();
        }
    }
