using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Một phần tử trong tập hợp
/// </summary>
public class Item
{
    string name;
    // Hàm khởi tạo
    public Item(string name)
    {
        this.name = name;
    }
    public string Name
    {
        get { return name; }
    }
}
