using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteIterator' (Iterator cụ thể)
/// </summary>

public class Iterator : IAbstractIterator
{
    Collection collection;
    int current = 0;
    int step = 1;

    // Constructor

    public Iterator(Collection collection)
    {
        this.collection = collection;
    }

    // Lấy phần tử đầu tiên

    public Item First()
    {
        current = 0;
        return collection[current] as Item;
    }

    // Lấy phần tử tiếp theo

    public Item Next()
    {
        current += step;
        if (!IsDone)
            return collection[current] as Item;
        else
            return null;
    }

    // Lấy hoặc thiết lập kích thước bước nhảy

    public int Step
    {
        get { return step; }
        set { step = value; }
    }

    // Lấy phần tử hiện tại trong lần lặp

    public Item CurrentItem
    {
        get { return collection[current] as Item; }
    }

    // Kiểm tra xem việc lặp đã hoàn thành chưa

    public bool IsDone
    {
        get { return current >= collection.Count; }
    }
}
