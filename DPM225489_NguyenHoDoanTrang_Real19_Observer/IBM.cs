using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteSubject' (Chủ thể cụ thể)
/// </summary>

public class IBM : Stock
{
    // Hàm khởi tạo

    public IBM(string symbol, double price)
        : base(symbol, price)
    {
    }
}
/// <summary>
/// Giao diện 'Observer' (Quan sát viên)
/// </summary>

public interface IInvestor
{
    void Update(Stock stock);
}