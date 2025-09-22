using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteFlyweight' (Flyweight cụ thể)
/// </summary>
public class ConcreteFlyweight : Flyweight
{
    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
    }
}
