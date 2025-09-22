using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'TerminalExpression' (Biểu thức kết thúc)
/// <remarks>
/// Thousand kiểm tra ký tự La Mã M 
/// </remarks>
/// </summary>
public class ThousandExpression : Expression
{
    public override string One() { return "M"; }
    public override string Four() { return " "; }
    public override string Five() { return " "; }
    public override string Nine() { return " "; }
    public override int Multiplier() { return 1000; }
}
