using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndAttendanceToCsv.Models
{
    internal class CustomTimeAndAttendanceModel
    {
            public string staticData { get; set; }
            public string employeeID { get; set; }
            public string inout { get; set; }
            public DateTime eventTime { get; set; }
        }
}
