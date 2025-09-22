using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Originator' (Nguồn gốc)
/// </summary>
public class SalesProspect
{
    string name;
    string phone;
    double budget;
    // Lấy hoặc thiết lập tên
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            Console.WriteLine("Name:   " + name);
        }
    }
    // Lấy hoặc thiết lập số điện thoại
    public string Phone
    {
        get { return phone; }
        set
        {
            phone = value;
            Console.WriteLine("Phone:  " + phone);
        }
    }
    // Lấy hoặc thiết lập ngân sách
    public double Budget
    {
        get { return budget; }
        set
        {
            budget = value;
            Console.WriteLine("Budget: " + budget);
        }
    }
    // Lưu trữ memento
    public Memento SaveMemento()
    {
        Console.WriteLine("\nSaving state --\n");
        return new Memento(name, phone, budget);
    }
    // Khôi phục memento
    public void RestoreMemento(Memento memento)
    {
        Console.WriteLine("\nRestoring state --\n");
        Name = memento.Name;
        Phone = memento.Phone;
        Budget = memento.Budget;
    }
}