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
    string name;
    string phone;
    double budget;
    // Hàm khởi tạo
    public Memento(string name, string phone, double budget)
    {
        this.name = name;
        this.phone = phone;
        this.budget = budget;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    public double Budget
    {
        get { return budget; }
        set { budget = value; }
    }
}
