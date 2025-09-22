using DPM225489_NguyenHoDoanTrang_Pattern20_State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteState' (Trạng thái cụ thể)
/// </summary>
public class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        context.State = new ConcreteStateB();
    }
}
