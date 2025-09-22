using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteState' (Trạng thái cụ thể)
/// <remarks>
/// Màu đỏ chỉ ra rằng tài khoản đã bị thấu chi
/// </remarks>
/// </summary>
public class RedState : State
{
    private double serviceFee;
    // Hàm khởi tạo
    public RedState(State state)
    {
        this.balance = state.Balance;
        this.account = state.Account;
        Initialize();
    }
    private void Initialize()
    {
        // Dữ liệu này có thể lấy từ nguồn dữ liệu
        interest = 0.0;
        lowerLimit = -100.0;
        upperLimit = 0.0;
        serviceFee = 15.00;
    }
    public override void Deposit(double amount)
    {
        balance += amount;
        StateChangeCheck();
    }
    public override void Withdraw(double amount)
    {
        amount = amount - serviceFee;
        Console.WriteLine("No funds available for withdrawal!");
    }
    public override void PayInterest()
    {
        // Không trả lãi
    }
    private void StateChangeCheck()
    {
        if (balance > upperLimit)
        {
            account.State = new SilverState(this);
        }
    }
}
