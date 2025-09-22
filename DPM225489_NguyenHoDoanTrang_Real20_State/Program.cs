using System;
using System.Security.Principal;

/// <summary>
/// Mẫu thiết kế State
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Mở một tài khoản mới
            Account account = new Account("Jim Johnson");
        // Thực hiện các giao dịch tài chính
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        // Chờ người dùng
            Console.ReadKey();
        }
    }