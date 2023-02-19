using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Logger
    {
        private static readonly string[] SaveMessage = new string[Starter.EndStarter()];
        private static int errorCount = 0;

        public static void Error(string message)
        {
            string m = DateTime.Now + " |ERROR| " + message;
            AddLog(m);
            errorCount++;
        }

        public static void Info(string message)
        {
            string m = DateTime.Now + " |INFO| " + message;
            AddLog(m);
            errorCount++;
        }

        public static void Warning(string message)
        {
            string m = DateTime.Now + " |WARNING| " + message;
            AddLog(m);
            errorCount++;
        }

        public static void SaveLog()
        {
            var file = new FileService();
            file.SaveFile(SaveMessage);
        }

        private static void AddLog(string m)
        {
            string message = m;
            Console.WriteLine(message);
            SaveMessage[errorCount] = message;
        }
    }
}
