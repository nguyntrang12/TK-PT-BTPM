using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteAggregate' (Tập hợp cụ thể)
/// </summary>
public class ConcreteAggregate : Aggregate
{
    List<object> items = new List<object>();
    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }
    // Lấy số lượng phần tử
    public int Count
    {
        get { return items.Count; }
    }
    // Trình truy xuất phần tử theo chỉ mục
    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}