using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Context' (Ngữ cảnh)
/// </summary>
public class Account
{
    private State state;
    private string owner;
    // Hàm khởi tạo
    public Account(string owner)
    {
        // Các tài khoản mới mặc định có trạng thái 'Silver'
        this.owner = owner;
        this.state = new SilverState(0.0, this);
    }
    public double Balance
    {
        get { return state.Balance; }
    }
    public State State
    {
        get { return state; }
        set { state = value; }
    }
    public void Deposit(double amount)
    {
        state.Deposit(amount);
        Console.WriteLine("Deposited {0:C} --- ", amount);
        Console.WriteLine(" Balance = {0:C}", this.Balance);
        Console.WriteLine(" Status  = {0}",
            this.State.GetType().Name);
        Console.WriteLine("");
    }
    public void Withdraw(double amount)
    {
        state.Withdraw(amount);
        Console.WriteLine("Withdrew {0:C} --- ", amount);
        Console.WriteLine(" Balance = {0:C}", this.Balance);
        Console.WriteLine(" Status  = {0}\n",
            this.State.GetType().Name);
    }
    public void PayInterest()
    {
        state.PayInterest();
        Console.WriteLine("Interest Paid --- ");
        Console.WriteLine(" Balance = {0:C}", this.Balance);
        Console.WriteLine(" Status  = {0}\n",
            this.State.GetType().Name);
    }
}
