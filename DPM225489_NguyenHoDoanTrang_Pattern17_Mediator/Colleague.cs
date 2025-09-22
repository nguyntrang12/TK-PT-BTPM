using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Colleague' (Đồng nghiệp)
/// </summary>
public abstract class Colleague
{
    protected Mediator mediator;
    // Hàm khởi tạo
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}
