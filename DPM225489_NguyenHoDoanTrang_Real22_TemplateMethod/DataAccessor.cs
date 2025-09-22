using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'DataAccessor' 
/// </summary>
public abstract class DataAccessor
{
    public abstract void Connect();
    public abstract void Select();
    public abstract void Process(int top);
    public abstract void Disconnect();
    // Phương thức "Template" 
    public void Run(int top)
    {
        Connect();
        Select();
        Process(top);
        Disconnect();
    }
}
