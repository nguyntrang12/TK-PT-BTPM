using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteCommand' (Lệnh cụ thể)
/// </summary>
public class ConcreteCommand : Command
{
    // Hàm khởi tạo
    public ConcreteCommand(Receiver receiver) :
        base(receiver)
    {
    }
    public override void Execute()
    {
        receiver.Action();
    }
}
