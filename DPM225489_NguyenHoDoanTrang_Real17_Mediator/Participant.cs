using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Colleague' (Đồng nghiệp)
/// </summary>
public class Participant
{
    Chatroom chatroom;
    string name;
    // Hàm khởi tạo
    public Participant(string name)
    {
        this.name = name;
    }
    // Lấy tên người tham gia
    public string Name
    {
        get { return name; }
    }
    // Lấy phòng chat
    public Chatroom Chatroom
    {
        set { chatroom = value; }
        get { return chatroom; }
    }
    // Gửi tin nhắn tới người tham gia được chỉ định
    public void Send(string to, string message)
    {
        chatroom.Send(name, to, message);
    }
    // Nhận tin nhắn từ người tham gia được chỉ định
    public virtual void Receive(
        string from, string message)
    {
        Console.WriteLine("{0} to {1}: '{2}'",
            from, Name, message);
    }
}

