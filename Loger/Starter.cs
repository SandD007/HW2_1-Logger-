using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Starter
    {
        private static readonly int LogCount = 100;

        public static void Run()
        {
            Random rand = new Random();

            for (int i = 0; i <= LogCount; i++)
            {
                if (rand.Next(1, 4) == 1)
                {
                    Actions.StartMethod();
                    continue;
                }

                if (rand.Next(1, 4) == 2)
                {
                    Actions.SkippedLogicInMethod();
                    continue;
                }

                if (rand.Next(1, 4) == 3)
                {
                    Actions.Error();
                    continue;
                }
            }

            Logger.SaveLog();
        }

        public static int EndStarter()
        {
            int logCount = Starter.LogCount + 1;
            return logCount;
        }
    }
}
