using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteState' (Trạng thái cụ thể)
/// <remarks>
/// Màu vàng chỉ ra rằng tài khoản có lãi suất
/// </remarks>
/// </summary>
public class GoldState : State
{
    // Constructor nạp chồng
    public GoldState(State state)
        : this(state.Balance, state.Account)
    {
    }
    public GoldState(double balance, Account account)
    {
        this.balance = balance;
        this.account = account;
        Initialize();
    }
    private void Initialize()
    {
        // Dữ liệu này có thể lấy từ cơ sở dữ liệu
        interest = 0.05;
        lowerLimit = 1000.0;
        upperLimit = 10000000.0;
    }
    public override void Deposit(double amount)
    {
        balance += amount;
        StateChangeCheck();
    }
    public override void Withdraw(double amount)
    {
        balance -= amount;
        StateChangeCheck();
    }
    public override void PayInterest()
    {
        balance += interest * balance;
        StateChangeCheck();
    }
    private void StateChangeCheck()
    {
        if (balance < 0.0)
        {
            account.State = new RedState(this);
        }
        else if (balance < lowerLimit)
        {
            account.State = new SilverState(this);
        }
    }
}
