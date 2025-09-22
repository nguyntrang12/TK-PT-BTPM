using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// <summary>
/// Lớp 'Context' (Ngữ cảnh)
/// </summary>

public class Context
{
    Strategy strategy;

    // Constructor

    public Context(Strategy strategy)
    {
        this.strategy = strategy;
    }

    public void ContextInterface()
    {
        strategy.AlgorithmInterface();
    }
}
