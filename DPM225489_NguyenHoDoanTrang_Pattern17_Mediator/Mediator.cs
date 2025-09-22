using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Mediator' (Người điều phối)
/// </summary>
public abstract class Mediator
{
    public abstract void Send(string message,
        Colleague colleague);
}
