using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteAggregate' (Tập hợp cụ thể)
/// </summary>
public class Collection : IAbstractCollection
{
    List<Item> items = new List<Item>();
    public Iterator CreateIterator()
    {
        return new Iterator(this);
    }
    // Lấy số lượng phần tử
    public int Count
    {
        get { return items.Count; }
    }
    // Trình truy xuất phần tử theo chỉ mục
    public Item this[int index]
    {
        get { return items[index]; }
        set { items.Add(value); }
    }
}

