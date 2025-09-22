using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Mediator' (Người điều phối)
/// </summary>

public abstract class AbstractChatroom
{
    public abstract void Register(Participant participant);
    public abstract void Send(
        string from, string to, string message);
}
