using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game
{
    public class Trace
    {
        public static TraceSource ts = new TraceSource("Application");
        static string ConfigFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/ASWC_Game/Config.xml";
        static Trace()
        {
            ts.Switch = new SourceSwitch("Application Log", "All");
            

            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter(ConfigFilePath));
            fileLog.Filter = new EventTypeFilter(SourceLevels.All);
            ts.Listeners.Add(fileLog);

            TraceListener consoleLog = new ConsoleTraceListener();
            ts.Listeners.Add(consoleLog);

        }
        public static void ApplicationLog(TraceEventType traceEventType, string message)
        {
            ts.TraceEvent(traceEventType, 01, message);
            ts.Flush();
        }
    }
}
