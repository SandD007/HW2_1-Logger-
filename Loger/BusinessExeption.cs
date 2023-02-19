using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class BusinessExeption : Exception
    {
        public BusinessExeption()
            : base("Action got this custom Exception: ")
        { 
        }

        public BusinessExeption(string message)
            : base(message) 
        {
        }

        public BusinessExeption(string message, Exception innerException)
            : base(message, innerException) 
        {
        }

        protected BusinessExeption(SerializationInfo info, StreamingContext context)
            : base(info, context) 
        {
        }

        public string MyInfo { get; set; }
    }
}
