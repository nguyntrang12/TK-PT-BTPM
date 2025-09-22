using System;
using System.Collections.Generic;

    /// <summary>
    /// Mẫu thiết kế Observer
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo cổ phiếu IBM và gắn các nhà đầu tư

            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Các thay đổi giá sẽ thông báo cho các nhà đầu tư

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Chờ người dùng

            Console.ReadKey();
        }
    }