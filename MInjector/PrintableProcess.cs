using System.Diagnostics;

namespace MInjector
{
    public class PrintableProcess
    {
        public Process InternalProcess { get; private set; }

        public PrintableProcess(Process p_Process)
        {
            InternalProcess = p_Process;
        }

        public override string ToString()
        {
            return string.Format("{0}.exe - (PID: {1})", InternalProcess.ProcessName, InternalProcess.Id);
        }
    }
}
