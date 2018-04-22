using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoNotifierUI
{
    class AutoNotifierException : Exception
    {
        public AutoNotifierException(String errorMessage) : base ("Application encountered an error : " + errorMessage)
        {
            // logging code
        }
    }
}
