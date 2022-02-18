using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkWebAPI.WebAPI.Services
{
    public class ConsoleLogger : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Console Log] - {message}");
        }
    }
    
}
