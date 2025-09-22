using DPM225489_NguyenHoDoanTrang_Pattern20_State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'State' (Trạng thái)
/// </summary>
public abstract class State
{
    public abstract void Handle(Context context);
}
