using System.IO.Pipes;
using WinMonitor.View;

namespace WinMonitor.Controller
{
    public class MonitorController : IMonitorController
    {
        private bool _isAlive;

        public MonitorController()
        {
            _isAlive = true;
        }

        public void RunMonitorLoop()
        {
            while (_isAlive)
            {
               ListenForInput();
            }
        }

        public void ListenForInput()
        {
            using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("MonitorPipe", PipeDirection.In))
            {
                Print.Blue("Now monitoring for WinLogger Commands");
                pipeServer.WaitForConnection();
                using (StreamReader sr = new StreamReader(pipeServer))
                {
                    string? temp = null;

                    // We read from the stream until the client has finished.
                    while (pipeServer.IsConnected)
                    {
                        // Read from the stream until the client sends a new command.
                        while ((temp = sr.ReadLine()) != null)
                        {
                            //TODO : Process Commands, exit command
                            Print.ProcessPrint(temp);
                        }
                    }

                }
            }
        }

        public void PrintOutput()
        {
            throw new NotImplementedException();
        }


    }
}

