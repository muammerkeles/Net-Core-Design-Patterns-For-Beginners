using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Design.Pattern.Sample.Static {
    public class Logger {
        private static Logger LoggerInstance;
        public Logger()
        {
        }
        public static Logger GetInstance {
            get {
               
                if (LoggerInstance == null)
                {
                    LoggerInstance= new Logger();
                }
                return LoggerInstance;
            }
        }
    }
}
