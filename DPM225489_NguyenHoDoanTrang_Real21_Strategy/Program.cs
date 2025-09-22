using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Strategy
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Hai ngữ cảnh với các chiến lược khác nhau
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        // Chờ người dùng
            Console.ReadKey();
        }
    }
