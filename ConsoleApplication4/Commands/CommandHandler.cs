using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Commands
{
    class CommandHandler
    {
        private Stack<ICommand> commands = new Stack<ICommand>();
        public void Execute(ICommand command)
        {
            command.Execute();
            commands.Push(command);
        }
        public void Undo()
        {
            if (commands.Count == 0 || !(commands.Peek() is UndoableCommand)) return;
            var command = (UndoableCommand)commands.Pop();
            command.Undo();
        }
    }
}
