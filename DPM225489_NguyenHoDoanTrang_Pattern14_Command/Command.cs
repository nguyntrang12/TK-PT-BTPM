using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteCommand' (Lệnh cụ thể)
/// </summary>
public abstract class Command
{
    protected Receiver receiver;
    // Constructor
    public Command(Receiver receiver)
    {
        this.receiver = receiver;
    }
    public abstract void Execute();
}
