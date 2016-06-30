using ConsoleApplication4.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.UI
{
    interface IUIConsole
    {
        void Initialize(Controller controller);
    }
}
