using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteColleague' (Đồng nghiệp cụ thể)
/// </summary>
public class NonBeatle : Participant
{
    // Hàm khời tạo
    public NonBeatle(string name)
        : base(name)
    {
    }
    public override void Receive(string from, string message)
    {
        Console.Write("To a non-Beatle: ");
        base.Receive(from, message);
    }
}
