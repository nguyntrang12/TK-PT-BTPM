using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Context' (Ngữ cảnh)
/// </summary>
public class Context
{
    State state;

    // Hàm khởi tạo

    public Context(State state)
    {
        this.State = state;
    }

    // Lấy hoặc thiết lập trạng thái

    public State State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("State: " + state.GetType().Name);
        }
    }

    public void Request()
    {
        state.Handle(this);
    }
}
