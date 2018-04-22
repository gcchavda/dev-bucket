using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zetalex.AutoNotifier.Helpers
{
    class AutoNotifierException : Exception
    {
        public AutoNotifierException(String errorMessage) : base ("Application encountered an error : " + errorMessage)
        {
            // logging code
        }
    }
}
