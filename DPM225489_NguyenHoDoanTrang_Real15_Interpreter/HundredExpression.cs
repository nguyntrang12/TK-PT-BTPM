using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'TerminalExpression' (Biểu thức kết thúc)
/// <remarks>
/// Hundred kiểm tra C, CD, D hoặc CM
/// </remarks>
/// </summary>
public class HundredExpression : Expression
{
    public override string One() { return "C"; }
    public override string Four() { return "CD"; }
    public override string Five() { return "D"; }
    public override string Nine() { return "CM"; }
    public override int Multiplier() { return 100; }
}
