using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Memento' (Kỷ vật)
/// </summary>
public class Memento
{
    string state;
    // Hàm khởi tạo
    public Memento(string state)
    {
        this.state = state;
    }
    public string State
    {
        get { return state; }
    }
}
