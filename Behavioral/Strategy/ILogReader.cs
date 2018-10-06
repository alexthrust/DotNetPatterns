using System.Collections.Generic;

namespace Strategy
{
    //Strategy
    public interface ILogReader
    {
        List<LogEntry> Read();
    }
}