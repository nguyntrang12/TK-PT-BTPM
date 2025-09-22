using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteObserver' (Quan sát viên cụ thể)
/// </summary>
public class ConcreteObserver : Observer
{
    private string name;
    private string observerState;
    private ConcreteSubject subject;
    // Hàm khởi tạo
    public ConcreteObserver(
        ConcreteSubject subject, string name)
    {
        this.subject = subject;
        this.name = name;
    }
    public override void Update()
    {
        observerState = subject.SubjectState;
        Console.WriteLine("Observer {0}'s new state is {1}",
            name, observerState);
    }
    // Lấy hoặc thiết lập chủ thể
    public ConcreteSubject Subject
    {
        get { return subject; }
        set { subject = value; }
    }
}
