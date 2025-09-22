using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp chứa chi tiết yêu cầu mua hàng
/// </summary>
public class Purchase
{
    int number;
    double amount;
    string purpose;
    // Hàm khởi tạo
    public Purchase(int number, double amount, string purpose)
    {
        this.number = number;
        this.amount = amount;
        this.purpose = purpose;
    }
    // Lấy hoặc thiết lập số yêu cầu mua hàng
    public int Number
    {
        get { return number; }
        set { number = value; }
    }
    // Lấy hoặc thiết lập số tiền yêu cầu mua hàng
    public double Amount
    {
        get { return amount; }
        set { amount = value; }
    }
    // Lấy hoặc thiết lập mục đích yêu cầu mua hàng
    public string Purpose
    {
        get { return purpose; }
        set { purpose = value; }
    }
}