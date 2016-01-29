using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceGUI.Loggging
{
    class Log
    {
        private IO.File logFile;
        private static Log Instance;        
        public enum Level
        {
            DEBUG,
            OUT,
            PRODUCTION,
        }

        private Log()
        {
            logFile = new IO.File("log.txt", IO.File.OPEN_TYPE.APPEND, null);
        }

        public void Write(String Message, Level Type, params object[] fmt)
        {
            String Out = String.Format("[{0}] - {1}\r\n", DateTime.Now.ToString("HH:mm:ss"), String.Format(Message, fmt));
            Console.Write(Out, fmt);
            logFile.writeAppend(Encoding.ASCII.GetBytes(Out));
        }

        public static Log Get()
        {
            if (Instance == null)
                Instance = new Log();
            return Instance;
        }
    }
}
