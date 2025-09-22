using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'State' (Trạng thái)
/// </summary>
public abstract class State
{
    protected Account account;
    protected double balance;
    protected double interest;
    protected double lowerLimit;
    protected double upperLimit;
    // Thuộc tính
    public Account Account
    {
        get { return account; }
        set { account = value; }
    }
    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }
    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
    public abstract void PayInterest();
}
