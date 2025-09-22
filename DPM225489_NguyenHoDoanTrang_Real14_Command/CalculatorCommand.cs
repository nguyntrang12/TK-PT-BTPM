using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'ConcreteCommand' (Lệnh cụ thể)
/// </summary>
public class CalculatorCommand : Command
{
    char @operator;
    int operand;
    Calculator calculator;
    // Hàm khởi tạo
    public CalculatorCommand(Calculator calculator,
        char @operator, int operand)
    {
        this.calculator = calculator;
        this.@operator = @operator;
        this.operand = operand;
    }
    // Lấy toán tử
    public char Operator
    {
        set { @operator = value; }
    }
    // Lấy toán hạng
    public int Operand
    {
        set { operand = value; }
    }
    // Thực thi lệnh mới
    public override void Execute()
    {
        calculator.Operation(@operator, operand);
    }
    // Hoàn tác lệnh cuối cùng
    public override void UnExecute()
    {
        calculator.Operation(Undo(@operator), operand);
    }
    // Trả về toán tử đối nghịch cho toán tử đã cho
    private char Undo(char @operator)
    {
        switch (@operator)
        {
            case '+': return '-';
            case '-': return '+';
            case '*': return '/';
            case '/': return '*';
            default:
                throw new
         ArgumentException("@operator");
        }
    }
}
