using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'UnsharedConcreteFlyweight' (Flyweight không chia sẻ)
/// </summary>
public class UnsharedConcreteFlyweight : Flyweight
{
    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine("UnsharedConcreteFlyweight: " +
            extrinsicstate);
    }
}
