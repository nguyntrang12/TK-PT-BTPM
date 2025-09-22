using DPM225489_NguyenHoDoanTrang_Real19_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Subject' (Chủ thể)
/// </summary>

public abstract class Stock
{
    private string symbol;
    private double price;
    private List<IInvestor> investors = new List<IInvestor>();

    // Constructor

    public Stock(string symbol, double price)
    {
        this.symbol = symbol;
        this.price = price;
    }

    public void Attach(IInvestor investor)
    {
        investors.Add(investor);
    }

    public void Detach(IInvestor investor)
    {
        investors.Remove(investor);
    }

    public void Notify()
    {
        foreach (IInvestor investor in investors)
        {
            investor.Update(this);
        }

        Console.WriteLine("");
    }

    // Lấy hoặc thiết lập giá

    public double Price
    {
        get { return price; }
        set
        {
            if (price != value)
            {
                price = value;
                Notify();
            }
        }
    }

    // Lấy mã cổ phiếu

    public string Symbol
    {
        get { return symbol; }
    }
}
