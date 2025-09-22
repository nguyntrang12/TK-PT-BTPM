using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteIterator' (Iterator cụ thể)
/// </summary>
public class ConcreteIterator : Iterator
{
    ConcreteAggregate aggregate;
    int current = 0;
    // Hàm khởi tạo
    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }
    // Lấy phần tử đầu tiên trong lần lặp
    public override object First()
    {
        return aggregate[0];
    }
    // Lấy phần tử tiếp theo trong lần lặp
    public override object Next()
    {
        object ret = null;
        if (current < aggregate.Count - 1)
        {
            ret = aggregate[++current];
        }
        return ret;
    }
    // Lấy phần tử hiện tại trong lần lặp
    public override object CurrentItem()
    {
        return aggregate[current];
    }
    // Kiểm tra xem các lần lặp đã hoàn thành chưa
    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }
}
