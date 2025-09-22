using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'TerminalExpression' (Biểu thức kết thúc)
/// <remarks>
/// One kiểm tra I, II, III, IV, V, VI, VII, VIII, IX
/// </remarks>
/// </summary>
public class OneExpression : Expression
{
    public override string One() { return "I"; }
    public override string Four() { return "IV"; }
    public override string Five() { return "V"; }
    public override string Nine() { return "IX"; }
    public override int Multiplier() { return 1; }
}
