using System;

    /// <summary>
    /// Mẫu thiết kế Memento
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
        // Lưu trạng thái nội bộ
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
        // Tiếp tục thay đổi trạng thái của originator
            o.State = "Off";
        // Khôi phục lại trạng thái đã lưu
            o.SetMemento(c.Memento);
        // Chờ người dùng
            Console.ReadKey();
        }
    }
