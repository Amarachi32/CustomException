using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class NameException : Exception
    {
        public override string Message
        {
            get
            {
                return "your Name Cannot be empty";
            }
        }
        public override string HelpLink
        {
            get
            {
                return "Get More Information from here: https://www.genesys.com/";
            }
        }
        public NameException()
        {
        }
        public NameException(string message) : base(message)
        {
        }
        public NameException(string message, Exception innerexception) : base(message, innerexception)
        {
        }
    }
}
