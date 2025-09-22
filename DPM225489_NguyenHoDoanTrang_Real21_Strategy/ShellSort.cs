using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteStrategy' (Chiến lược cụ thể)
/// </summary>
public class ShellSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        //list.ShellSort();  not-implemented
        Console.WriteLine("ShellSorted list ");
    }
}
