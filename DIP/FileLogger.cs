using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Code to write log to a file
            Console.WriteLine("Log to file: " + message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Code to write log to a database
            Console.WriteLine("Log to database: " + message);
        }
    }
}
