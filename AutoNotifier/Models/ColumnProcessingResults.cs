using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNotifier.Models
{
    public class ColumnProcessingResults
    {
        public String RecNo { get; set; }
        public List<EachColumnResult> colResults { get; set;}
    }

    public class EachColumnResult
    {
        public String currentValue { get; set; }
        public String criteria { get; set; }
        public String columnName { get; set; }
    }

}
