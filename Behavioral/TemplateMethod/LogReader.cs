using System.Collections.Generic;
using System.Linq;
using Models;

namespace TemplateMethod
{
    //AbstractClass
    public abstract class LogReader
    {
        private int _currentPosition;

        //TemplateMethod
        public IEnumerable<LogEntry> ReadLogEntry()
        {
            return ReadEntries(ref _currentPosition).Select(ParseLogEntry);
        }
        protected abstract IEnumerable<string> ReadEntries(ref int position);
        protected abstract LogEntry ParseLogEntry(string stringEntry);
    }
}