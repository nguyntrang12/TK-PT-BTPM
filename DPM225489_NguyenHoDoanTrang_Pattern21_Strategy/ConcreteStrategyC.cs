using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteStrategy' (Chiến lược cụ thể)
/// </summary>

public class ConcreteStrategyC : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine(
            "Called ConcreteStrategyC.AlgorithmInterface()");
    }
}
