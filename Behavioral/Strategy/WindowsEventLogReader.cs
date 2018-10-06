using System;
using System.Collections.Generic;

namespace Strategy
{
    //ConcreteStrategy
    public class WindowsEventLogReader : ILogReader
    {
        public List<LogEntry> Read()
        {
            return new List<LogEntry>
            {
                new LogEntry
                {
                    Date = DateTime.Now,
                    Message = "Log from windows event logs",
                    Type = "WindowsEventLog"
                }
            };
        }
    }
}