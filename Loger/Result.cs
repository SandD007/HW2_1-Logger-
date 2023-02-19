using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Result
    {
        private const string REASON = "Action failed by а reason: ";

        public static string Status(bool status, string message)
        {
            if (!status)
            {
               string mes = REASON + message;
               return mes;
            }
            else
            {
               string mes = message;
               return mes;
            }
        }
    }
}
