using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteColleague' (Đồng nghiệp cụ thể)
/// </summary>
public class ConcreteColleague2 : Colleague
{
    // Hàm khởi tạo
    public ConcreteColleague2(Mediator mediator)
        : base(mediator)
    {
    }
    public void Send(string message)
    {
        mediator.Send(message, this);
    }
    public void Notify(string message)
    {
        Console.WriteLine("Colleague2 gets message: "
            + message);
    }
}
