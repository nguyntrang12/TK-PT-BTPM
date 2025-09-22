using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Command' (Lệnh)
/// </summary>
public abstract class Command
{
    public abstract void Execute();
    public abstract void UnExecute();
}
