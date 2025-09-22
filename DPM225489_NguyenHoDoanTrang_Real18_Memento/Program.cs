using System;
/// <summary>
/// Mẫu thiết kế Memento
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;
        // Lưu trạng thái nội bộ
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();
        // Tiếp tục thay đổi đối tượng gốc
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;
        // Khôi phục trạng thái đã lưu
            s.RestoreMemento(m.Memento);
        // Chờ người dùng
            Console.ReadKey();
        }
    }
