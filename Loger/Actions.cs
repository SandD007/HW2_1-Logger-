using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loger
{
    static class Actions
    {
        private const string START_METHOD = "Start metgod.";
        private const string SKIPPED_LOGIC_METHOD = "Skipped logic in method.";
        private const string ERROR = "I broke a logic.";
        private static bool Status { get; set; }

        public static void StartMethod()
        {
            Status = true;
            Logger.Info(Result.Status(Status, START_METHOD));
        }
        public static void SkippedLogicInMethod()
        {
            Status = true;
            Logger.Warning(Result.Status(Status, SKIPPED_LOGIC_METHOD));
        }
        public static void Error()
        {
            Status = false;
            Logger.Error(Result.Status(Status, ERROR));
        }

    }
}
