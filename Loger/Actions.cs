using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Actions
    {
        private const string STARTMETHOD = "Start method.";
        private const string SKIPPEDLOGICMETHOD = "Skipped logic in method.";
        private const string ERROR = "I broke a logic.";

        private static bool Status { get; set; }

        public static void StartMethod()
        {
            Status = true;
            Logger.Info(Result.Status(Status, STARTMETHOD));
        }

        public static void SkippedLogicInMethod()
        {
            Status = true;
            try
            {
                throw new BusinessExeption();
            }
            catch (BusinessExeption exeption)
            {
                Logger.Warning(exeption.Message + Result.Status(Status, SKIPPEDLOGICMETHOD));
            }
        }

        public static void Error()
        {
            Status = false;
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                Logger.Error(Result.Status(Status, ERROR));
            }
        }
    }
}
