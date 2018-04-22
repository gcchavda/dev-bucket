using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zetalex.AutoNotifier.Helpers
{
    public enum JobEnum
    {
        [JobState(interval: 10)]
        TestJob = 1
    }
}
