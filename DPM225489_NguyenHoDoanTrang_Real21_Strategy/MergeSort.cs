using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteStrategy' (Chiến lược cụ thể)
/// </summary>
public class MergeSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        //list.MergeSort(); not-implemented
        Console.WriteLine("MergeSorted list ");
    }
}
