using System;
using System.IO;

/// <summary>
/// Mẫu thiết kế Chain of Responsibility (Chuỗi trách nhiệm)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Thiết lập chuỗi trách nhiệm
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();
            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);
        // Tạo và xử lý các yêu cầu mua hàng
            Purchase p = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p);
            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);
            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
        //  Chờ người dùng nhấn phím
            Console.ReadKey();
        }
    }
