using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loger
{
    static class Result
    {
        private const string REASON = "Action failed by а reason: ";

        public static string Status(bool status, string message)
        {
            if (!status)
            {
               string Message = REASON + message;
               return Message;
            }
            else
            {
               string Message = message;
               return Message;
            }
        }
    }
}
