using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Logger
    {

        private static Logger _logger;
        private static readonly object _lock = new object();

        private Logger()
        {

        }
        public static Logger GetLogger()
        {
            lock (_lock)
            {
                if (_logger == null)
                {
                    _logger = new Logger();
                }
            }
            return _logger;
        }


        public void WriteLogToDB(string message, string applicationName)
        {
            var recordToAdd = new Log()
            {
                ApplicationName = applicationName,
                CreationTime = DateTime.Now,
                ErrorMessage = message

            };
                var context = new LogContext();
            context.Logs.Add(recordToAdd);
            context.SaveChanges();

        }
    }
}


