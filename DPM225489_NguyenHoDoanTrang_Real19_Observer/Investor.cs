using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteObserver' (Quan sát viên cụ thể)
/// </summary>
public class Investor : IInvestor
{
    private string name;
    private Stock stock;
    // Hàm khởi tạo
    public Investor(string name)
    {
        this.name = name;
    }
    public void Update(Stock stock)
    {
        Console.WriteLine("Notified {0} of {1}'s " +
            "change to {2:C}", name, stock.Symbol, stock.Price);
    }
    // Lấy hoặc thiết lập cổ phiếu
    public Stock Stock
    {
        get { return stock; }
        set { stock = value; }
    }
}
