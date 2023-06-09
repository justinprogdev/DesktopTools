using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMonitor.Controller
{
    public interface IMonitorController
    {
        public void RunMonitorLoop();

        public void ListenForInput();

        public void PrintOutput();  
    }
}
