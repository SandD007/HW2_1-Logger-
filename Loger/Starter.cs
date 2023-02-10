using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loger
{
    static class Starter
    {
        private static int _logCount = 100;
        public static void Run()
        {
            for (int i = 0; i <= _logCount; i++)
            {
                int rand = new Random().Next(1, 4);
                if (rand == 1)
                {
                    Actions.StartMethod();
                    continue;
                }
                if (rand == 2)
                {
                    Actions.SkippedLogicInMethod();
                    continue;
                }
                if (rand == 3)
                {
                    Actions.Error();
                    continue;
                }
            }
            Logger.SaveLog();
        }
        public static int EndStarter()
        {
            int logCount = _logCount + 1;
            return logCount;
        }
    }
}
