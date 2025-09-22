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
    string input;
    int output;
    // Hàm khởi tạo
    public Context(string input)
    {
        this.input = input;
    }
    public string Input
    {
        get { return input; }
        set { input = value; }
    }
    public int Output
    {
        get { return output; }
        set { output = value; }
    }
}
