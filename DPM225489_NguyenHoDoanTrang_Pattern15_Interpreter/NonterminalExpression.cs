using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'NonterminalExpression' (Biểu thức không phải kết thúc)
/// </summary>

public class NonterminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        Console.WriteLine("Called Nonterminal.Interpret()");
    }
}
