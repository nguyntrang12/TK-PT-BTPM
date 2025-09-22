using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteFlyweight' (Flyweight cụ thể)
/// </summary>
public class CharacterA : Character
{
    // Hàm khởi tạo
    public CharacterA()
    {
        symbol = 'A';
        height = 100;
        width = 120;
        ascent = 70;
        descent = 0;
    }
    public override void Display(int pointSize)
    {
        this.pointSize = pointSize;
        Console.WriteLine(symbol +
            " (pointsize " + this.pointSize + ")");
    }
}
