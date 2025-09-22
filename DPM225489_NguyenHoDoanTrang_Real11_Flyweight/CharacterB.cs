using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteFlyweight' (Flyweight cụ thể)
/// </summary>
public class CharacterB : Character
{
    // Hàm khởi tạo
    public CharacterB()
    {
        symbol = 'B';
        height = 100;
        width = 140;
        ascent = 72;
        descent = 0;
    }
    public override void Display(int pointSize)
    {
        this.pointSize = pointSize;
        Console.WriteLine(this.symbol +
            " (pointsize " + this.pointSize + ")");
    }
}
