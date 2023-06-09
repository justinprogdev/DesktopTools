using WinMonitor.View;

namespace WinMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMonitorView monitor = new MonitorView();
            monitor.StartMonitoring();
        }
    }
}