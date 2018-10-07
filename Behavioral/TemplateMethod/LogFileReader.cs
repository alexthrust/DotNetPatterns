using System;
using System.Collections.Generic;
using Models;

namespace TemplateMethod
{
    public class LogFileReader : LogReader
    {
        protected override IEnumerable<string> ReadEntries(ref int position)
        {
            return new List<string>
            {
                "Message 1",
                "Message 2"
            };
        }

        protected override LogEntry ParseLogEntry(string stringEntry)
        {
            return new LogEntry
            {
                Date = DateTime.Now,
                Message = stringEntry,
                Type = "File"
            };
        }
    }
}