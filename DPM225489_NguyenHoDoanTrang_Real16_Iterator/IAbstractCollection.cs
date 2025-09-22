using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Giao diện 'Aggregate' (Tập hợp)
/// </summary>

public interface IAbstractCollection
{
    Iterator CreateIterator();
}
