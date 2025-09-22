using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'AbstractExpression' (Biểu thức trừu tượng)
/// </summary>

public abstract class AbstractExpression
{
    public abstract void Interpret(Context context);
}