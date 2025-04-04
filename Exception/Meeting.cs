using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception;

class Meeting
{
    public string FullName { get; set; }
    public DateTime ToDate { get; set; }
    public DateTime FromDate { get; set; }

    public Meeting(string fullname, DateTime todate, DateTime fromdate)
    {
        FullName = fullname;
        ToDate = todate;
        FromDate = fromdate;
    }
}