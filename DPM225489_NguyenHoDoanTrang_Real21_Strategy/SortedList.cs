using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Context' (Ngữ cảnh)
/// </summary>
public class SortedList
{
    private List<string> list = new List<string>();
    private SortStrategy sortstrategy;
    public void SetSortStrategy(SortStrategy sortstrategy)
    {
        this.sortstrategy = sortstrategy;
    }
    public void Add(string name)
    {
        list.Add(name);
    }
    public void Sort()
    {
        sortstrategy.Sort(list);
        // Duyệt qua danh sách và hiển thị kết quả
        foreach (string name in list)
        {
            Console.WriteLine(" " + name);
        }
        Console.WriteLine();
    }
}
