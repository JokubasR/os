using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.Exception
{
    class BadAddressException : System.Exception
    {
        public BadAddressException()
        { }

        public BadAddressException(string message)
            : base(message)
        { }

        public BadAddressException(string message, System.Exception inner)
            : base(message, inner)
        { }
    }
}
