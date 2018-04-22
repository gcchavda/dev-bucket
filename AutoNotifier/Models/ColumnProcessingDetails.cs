using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNotifier.Models
{
    public class ColumnProcessingDetails
    {
        public String query { get; set; }
        public String columnName { get; set; }
        public String criteria { get; set; }
    }
}
