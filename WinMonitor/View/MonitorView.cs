using WinMonitor.Controller;

namespace WinMonitor.View
{
    /// <summary>
    /// The UI
    /// Enter Commands
    /// Receive Output
    /// </summary>
    public class MonitorView : IMonitorView
    {


        public MonitorView()
        {
            StartMonitoring();
        }
        public void StartMonitoring()
        {

            IMonitorController monitorController = new MonitorController();
            Print.Blue("Now monitoring for WinLogger Commands");
            monitorController.RunMonitorLoop();
            
        }
    }
}
