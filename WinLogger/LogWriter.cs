using System;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace WinLogger
{
    public class LogWriter
    {
        private readonly NamedPipeClientStream _pipeClient;
        private bool disposedValue;

        public LogWriter()
        {
            var pipe = new NamedPipeClientStream(".", "MonitorPipe", PipeDirection.Out);
            _pipeClient = pipe;
            _pipeClient.Connect();

        }

        public void WriteToPipeClient(LoggerOption loggerOption, string value)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_pipeClient))
                {
                    sw.AutoFlush = true;
                    sw.Write($"{loggerOption}**#**{value}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
