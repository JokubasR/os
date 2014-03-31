using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.Exception
{
    [Serializable]
    class NotValidDataException : System.Exception
    {
        public NotValidDataException()
        { }

        public NotValidDataException(string message)
            : base(message)
        { }

        public NotValidDataException(string message, System.Exception inner)
            : base(message, inner)
        { }
    }
}
