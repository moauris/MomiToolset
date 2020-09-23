using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MomiToolset
{
    public class Debugburr
    {
        public void Test()
        {
            Trace.Listeners.Clear();
            string timeStamp = DateTime.Now.ToString("yyyy_MMdd_hhmmss_");
            TextWriterTraceListener tl = new TextWriterTraceListener($".\\Logs\\{timeStamp}Log.log");
            tl.TraceOutputOptions = TraceOptions.DateTime | TraceOptions.Callstack | TraceOptions.ProcessId;
            Trace.Listeners.Add(tl);

            Trace.WriteLine("Testing Starts");
            Random rand = new Random();
            Trace.Write("正在进行某种复杂运算");
            for (int i = 0; i < 30; i++)
            {
                int SleepMS = rand.Next(10, 50);
                Thread.Sleep(SleepMS);
                Trace.Write(".");

            }
            Trace.WriteLine("完成！");
            Trace.TraceWarning("某种警告！");



            Trace.WriteLine("Testing Ends");
            Trace.Close();
        }
    }
}
