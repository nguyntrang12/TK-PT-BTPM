using System;
using System.Collections.Generic;

    /// <summary>
    /// Mẫu thiết kế Iterator (Lặp qua tập hợp)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Xây dựng một tập hợp

            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Tạo iterator

            Iterator iterator = collection.CreateIterator();

            // Bỏ qua mỗi phần tử thứ hai

            iterator.Step = 2;

            Console.WriteLine("Lặp qua tập hợp:");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            // Chờ người dùng

            Console.ReadKey();
        }
    }