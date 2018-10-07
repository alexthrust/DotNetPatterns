using System.Collections.Generic;
using Models;

namespace Strategy
{
    //Strategy
    public interface ILogReader
    {
        List<LogEntry> Read();
    }
}