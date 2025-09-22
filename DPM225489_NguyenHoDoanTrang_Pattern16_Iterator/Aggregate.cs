using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Aggregate' (Tập hợp)
/// </summary>
public abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}