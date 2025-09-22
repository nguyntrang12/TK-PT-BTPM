using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Proxy' (Đại diện)
/// </summary>
public class Proxy : Subject
{
    private RealSubject realSubject;
    public override void Request()
    {
        // Sử dụng 'khởi tạo lười biếng' (lazy initialization)
        if (realSubject == null)
        {
            realSubject = new RealSubject();
        }
        realSubject.Request();
    }
}
