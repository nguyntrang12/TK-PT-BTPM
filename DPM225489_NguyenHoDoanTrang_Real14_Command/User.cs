using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp 'Invoker' (Người gọi)
/// </summary>
public class User
{
    // Khởi tạo
    Calculator calculator = new Calculator();
    List<Command> commands = new List<Command>();
    int current = 0;
    public void Redo(int levels)
    {
        Console.WriteLine("\n---- Redo {0} levels ", levels);
        // Thực hiện các thao tác làm lại
        for (int i = 0; i < levels; i++)
        {
            if (current < commands.Count - 1)
            {
                Command command = commands[current++];
                command.Execute();
            }
        }
    }
    public void Undo(int levels)
    {
        Console.WriteLine("\n---- Undo {0} levels ", levels);

        // Thực hiện các thao tác hoàn tác
        for (int i = 0; i < levels; i++)
        {
            if (current > 0)
            {
                Command command = commands[--current] as Command;
                command.UnExecute();
            }
        }
    }
    public void Compute(char @operator, int operand)
    {
        // Tạo lệnh và thực thi
        Command command = new CalculatorCommand(calculator, @operator, operand);
        command.Execute();
        // Thêm lệnh vào danh sách hoàn tác
        commands.Add(command);
        current++;
    }
}
