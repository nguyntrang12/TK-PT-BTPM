using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Originator' (Nguồn gốc)
/// </summary>
public class Originator
{
    string state;
    public string State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("State = " + state);
        }
    }
    // Tạo memento 
    public Memento CreateMemento()
    {
        return (new Memento(state));
    }
    // Khôi phục lại trạng thái ban đầu
    public void SetMemento(Memento memento)
    {
        Console.WriteLine("Restoring state...");
        State = memento.State;
    }
}
