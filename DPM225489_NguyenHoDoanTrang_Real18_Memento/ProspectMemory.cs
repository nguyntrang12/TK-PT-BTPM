using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Caretaker' (Người chăm sóc)
/// </summary>
public class ProspectMemory
{
    Memento memento;

    public Memento Memento
    {
        set { memento = value; }
        get { return memento; }
    }
}