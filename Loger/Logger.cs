using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loger
{
    static class Logger
    {
        private static string[] _saveMessage = new string[Starter.EndStarter()];
        private static int _errorCount = 0;
        public static void Error(string message)
        {
            string m = DateTime.Now + " |ERROR| " + message;
            AddLog(m);
            _errorCount++;
        }
        public static void Info(string message)
        {
            string m = DateTime.Now + " |INFO| " + message;
            AddLog(m);
            _errorCount++;
        }
        public static void Warning(string message)
        {
            string m = DateTime.Now + " |WARNING| " + message;
            AddLog(m);
            _errorCount++;
        }
        private static void AddLog (string m)
        {
            string message = m;
            Console.WriteLine(message);
            _saveMessage[_errorCount] = message;
        }
        public static void SaveLog()
        {
            File.WriteAllText("log.txt", string.Join("\n", _saveMessage));
        }
    }
}
