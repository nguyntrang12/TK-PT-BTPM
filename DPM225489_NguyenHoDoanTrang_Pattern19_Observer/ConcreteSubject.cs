using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteSubject' (Chủ thể cụ thể)
/// </summary>
public class ConcreteSubject : Subject
{
    private string subjectState;

    // Lấy hoặc thiết lập trạng thái của chủ thể

    public string SubjectState
    {
        get { return subjectState; }
        set { subjectState = value; }
    }
}